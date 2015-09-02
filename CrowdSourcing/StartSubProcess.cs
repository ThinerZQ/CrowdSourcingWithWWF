using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
   public class StartSubProcess
    {
        public static int count = 3;
        public void startSubDivideProcess(Guid parentWorkflowId,CrowdTask task)
        {
            //创建输入参数
           Dictionary<string, object> para = new Dictionary<string, object>();
           
            CrowdTask crowdTask = new CrowdTask();
            crowdTask.taskName = task.taskName;
            crowdTask.taskDescription = task.taskDescription;
            crowdTask.taskParentWorkflowId=parentWorkflowId.ToString();
            crowdTask.taskType = TaskType.decomposeTask;
            
            para.Add("parentWorkflowId", parentWorkflowId);
            para.Add("task", crowdTask);
            //创建实例对象
             WorkflowApplication  currentWorkflowInstance = new WorkflowApplication(new decompose(), para);

            //委托流程结束时候调用的方法
             currentWorkflowInstance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(SubDivideWorkflowCompleted);

            //启动实例
            currentWorkflowInstance.Run();

            //继续绑定crowdTask 参数
            crowdTask.taskWorkflowId = currentWorkflowInstance.Id.ToString();
            
            //将这个任务插入到到数据库

            CrowdTaskService crowdTaskService = new CrowdTaskService();
            int result = crowdTaskService.insert(crowdTask);

            //更新每个实例的主工作流Id
            crowdTaskService.updateCrowdTaskMainTaskIdByWorkflowId(currentWorkflowInstance.Id.ToString());

            if (result == 1)
            {
                //将当前实例加入到分解任务集合中
                MyWorkflowInstance.setDecomposeWorkflowApplication(currentWorkflowInstance.Id.ToString(), currentWorkflowInstance);
            }
        }
        void SubDivideWorkflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {

            //流程结束，将流程实例移除
            MyWorkflowInstance.removeDecomposeWorkflowApplication(e.InstanceId.ToString());

           
            CrowdTaskService crowdTaskService = new CrowdTaskService();
            //将当前流程的分解解决方案写入数据库
            int result = crowdTaskService.saveDecomposeResult(e.InstanceId.ToString(),(ArrayList)e.Outputs["out_arraylist_task"]);

            //得到当前分解任务的内容
            CrowdTask crowdTask = new CrowdTask();
            crowdTask =  crowdTaskService.findCrowdTaskByWorkflowId(e.InstanceId.ToString());

            //通过当前分解任务的父工作流ID ，获得该父工作流的所有子工作流，如果都完成了则开启分解判断过程
            ArrayList allSonCrowdTask = crowdTaskService.findAllSonCrowdTaskByParentWorkflowIdAndTaskName(crowdTask.taskParentWorkflowId, crowdTask.taskName,crowdTask.mainTaskId);
            
            Dictionary<string, ArrayList> solutionTasks = new Dictionary<string, ArrayList>();

            int count = 0;
            //遍历看看这个任务的同一级的分解任务是否都结束了
            foreach (CrowdTask ct in allSonCrowdTask)
             {
                 WorkflowApplication wa = MyWorkflowInstance.getDecomposeWorkflowApplication(ct.taskWorkflowId);
                 if (wa != null)
                 {
                     break;
                 }
                 else
                 {
                     count++;
                 }
             }
            //如果都结束了
             if (count == ConstantDefine.divideNumber)
             {

                 //获得每一个分解任务给出的解决方案
                 foreach (CrowdTask ct in allSonCrowdTask)
                 {
                     ArrayList solutions = crowdTaskService.findDecomposeResultByWorkflowId(ct.taskWorkflowId,ct.mainTaskId);
                     if (solutions.Count != 0)
                     {
                         //表示当前工作流Id给出了分解方案
                         solutionTasks.Add(ct.taskWorkflowId, solutions);
                     }
                 }
                 //表示至少有一个分解任务给出了解决方案
                 if (solutionTasks.Count != 0)
                 {
                     //开启5个投票流程  工作流实例
                     for (int i = 0; i < ConstantDefine.decomposeVotingNumber; i++)
                     {
                         StartSubProcess ssp = new StartSubProcess();
                         ssp.startDevideVotingProcess(solutionTasks);
                     }
                 }
                 //表示所有的当前这几个分解任务都认为这个任务是简单任务，设置简单标记
                 else
                 {
                     //当前一个任务判定为简单，是要等这一层级的所有任务都判定完了在根据情况，把这一层是简单的任务抛出去
                     foreach (CrowdTask ct in allSonCrowdTask)
                     {
                         int h = crowdTaskService.updateDecomposeResultByWokflowIdAndTaskName(ct.taskParentWorkflowId, ct.taskName,ct.mainTaskId);
                     }

                 } 


                 /*
                 //等待这一层的所有任务都分解完成了，把这一层的简单任务选出来，分发出去
                 ArrayList ThisLayerAllSonCrowdTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskType(crowdTask.taskParentWorkflowId, TaskType.decomposeTask);
                 int count1 = 0;
                 //遍历这一层的任务，看看是否都完成了
                 foreach (CrowdTask ct in ThisLayerAllSonCrowdTask)
                 {
                     WorkflowApplication wa = MyWorkflowInstance.getDecomposeWorkflowApplication(ct.taskWorkflowId);
                     if (wa != null)
                     {
                         break;
                     }
                     else
                     {
                         count1++;
                     }
                 }
                 //这一层的所有任务都完成了
                 if (ThisLayerAllSonCrowdTask.Count == count1)
                 {
                     ArrayList al_simple = crowdTaskService.getAllThisLayerNeedSolvedCrowTaskInDecomposeResult(crowdTask.taskParentWorkflowId);
                     //可以得到这一层一共有多少个简单任务
                     //将每一个简单任务分发出去启动解决流程
                     foreach (DecomposeResult al in al_simple)
                     {
                         for (int k = 0; k < ConstantDefine.solvingNumber; k++)
                         {
                             //将这个任务分发出去
                             CrowdTask ct = new CrowdTask();
                             ct.taskName = al.taskName;
                             ct.taskDescription = al.taskDescription;
                             ct.taskType = TaskType.solveTask;
                             StartSubProcess ssp = new StartSubProcess();
                             ssp.startSolveProcess(ct);
                         }
                     }
                 }
                  * */
             }

             //如果分解的工作流为空。

             if (MyWorkflowInstance.getdecomposeWorkflowApplications().Count == 0 && MyWorkflowInstance.getdecomposeVotingWorkflowApplications().Count==0)
             {
                 //加载所有的需要解决的任务，作为解决任务发放出去

                 ArrayList li = crowdTaskService.getAllNeedSolvedCrowTaskInDecomposeResult1(crowdTask.mainTaskId);
                 foreach (DecomposeResult dr in li)
                 {
                     for (int k = 0; k < ConstantDefine.solvingNumber; k++)
                     {
                         //将这个任务分发出去
                         CrowdTask ct = new CrowdTask();
                         ct.taskName = dr.taskName;
                         ct.taskDescription = dr.taskDescription;
                         ct.taskType = TaskType.solveTask;
                         ct.taskParentWorkflowId = dr.parent_workflow_id;
                         StartSubProcess ssp = new StartSubProcess();
                         ssp.startSolveProcess(ct);
                     }
                 }

                   MyWorkflowInstance.getWorkflowApplication(crowdTask.mainTaskId).ResumeBookmark(BookmarkName.Decomposing,null); ;
             }


        }
        public void startDevideVotingProcess(Dictionary<string, ArrayList> solutionTasks)
        {
            //创建输入参数
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("solutionTasks", solutionTasks);

            //创建实例对象
            WorkflowApplication  currentWorkflowInstance = new WorkflowApplication(new decomposeVoting(), para);

            //委托流程结束时候调用的方法
            currentWorkflowInstance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(DevideVotingWorkflowCompleted);

            //启动实例
            currentWorkflowInstance.Run();

            CrowdTaskService crowdTaskService = new CrowdTaskService();
            //分解任务
            CrowdTask divideTask = crowdTaskService.findCrowdTaskByWorkflowId(solutionTasks.First().Key);

         
            CrowdTask crowdTask = new CrowdTask();
            crowdTask.taskName = divideTask.taskName;
            crowdTask.taskDescription = divideTask.taskDescription;
            crowdTask.taskType = TaskType.decomposeVotingTask;

            crowdTask.taskWorkflowId = currentWorkflowInstance.Id.ToString();

            crowdTask.taskParentWorkflowId = crowdTaskService.findCrowdTaskByWorkflowId(solutionTasks.Keys.First().ToString()).taskParentWorkflowId;


            int result = crowdTaskService.insert(crowdTask);

            //更新每个实例的主工作流Id
            crowdTaskService.updateCrowdTaskMainTaskIdByWorkflowId(currentWorkflowInstance.Id.ToString());


            if (result == 1)
            {
                //将当前实例加入到分解任务集合中
                MyWorkflowInstance.setDecomposeVotingWorkflowApplication(currentWorkflowInstance.Id.ToString(), currentWorkflowInstance);
            }
        }



        void DevideVotingWorkflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {

          
            MyWorkflowInstance.removeVotingDecomposeWorkflowApplication(e.InstanceId.ToString());


            CrowdTask crowdTask = new CrowdTask();
            CrowdTaskService crowdTaskService = new CrowdTaskService();

            //将当前流程的投票的分解的工作流ID写入数据库
            int result = crowdTaskService.saveDecomposeVoteResult(e.InstanceId.ToString(), (string)e.Outputs["out_bestSolutionWorkflowId"]);


            crowdTask = crowdTaskService.findCrowdTaskByWorkflowId(e.InstanceId.ToString());

            //通过当前任务的父工作流ID ，获得该父工作流的所有子工作流，如果都完成了则开启分解判断过程
            int count = 0;

            ArrayList allSonCrowdTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(crowdTask.taskParentWorkflowId, crowdTask.taskName,TaskType.decomposeVotingTask,crowdTask.mainTaskId);

           // Dictionary<string, ArrayList> solutionTasks = new Dictionary<string, ArrayList>();
         //   Dictionary<string, int> dic=null;
            foreach (CrowdTask ct in allSonCrowdTask)
            {
                WorkflowApplication wa = MyWorkflowInstance.getDecomposeVotingWorkflowApplication(ct.taskWorkflowId);
                if (wa != null)
                {
                    //有一个不为空就表示改父工作流的所有子工作流没有都完成
                    break;
                }
                else
                {
                    //表示完成了
                    count++;
                }
            }
            if (count == ConstantDefine.decomposeVotingNumber)
            {

                //得到这个投票任务的结果

               ArrayList arraylist1=  crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(crowdTask.taskParentWorkflowId,crowdTask.taskName,TaskType.decomposeTask,crowdTask.mainTaskId);

                //将arrayList1里面的每个任务取出来，将其ID获得，然后根据ID去decomposeResult 里面取值

               int[] nums = new int[ConstantDefine.divideNumber];
               string[] votedId = new string[ConstantDefine.divideNumber];
               int i=0;
               foreach ( CrowdTask ct in arraylist1)
               {
                   //在这里将去检索数据库
                   Dictionary<string,int> dict =  crowdTaskService.findSupportThisIdNumber(ct.taskWorkflowId);
                   if(dict.Count!=0){
                          nums[i] = dict.First().Value;
                          votedId[i] =dict.First().Key;
                   }
                   else
                   {
                       nums[i] = 0;
                       votedId[i] = "";
                   }
                     i++;
               }
               string bestSolutionWorkflowId = votedId[0];
               int max = nums[0];
               for (int t = 0; t < nums.Length; t++)
               {
                   if (nums[t] > max)
                   {
                       max = nums[t];
                       bestSolutionWorkflowId = votedId[t];
                   }

               }
                ArrayList bestSolutionArrayList = crowdTaskService.findDecomposeResultByWorkflowId(bestSolutionWorkflowId,crowdTask.mainTaskId);

                //设置投票标记
                crowdTaskService.updateDecomposeResultVotedByWorkflowId(bestSolutionWorkflowId);



                foreach(DecomposeResult dr in bestSolutionArrayList){
                    //开启5个投票流程  工作流实例
                    for (int m = 0; m < ConstantDefine.divideNumber; m++)
                    {
                        CrowdTask task = new CrowdTask();
                        task.taskName=dr.taskName;
                        task.taskDescription=dr.taskDescription;
                        task.taskParentWorkflowId=bestSolutionWorkflowId;
                        task.taskType=TaskType.decomposeTask;
                        StartSubProcess ssp = new StartSubProcess();
                        ssp.startSubDivideProcess(new Guid(bestSolutionWorkflowId),task);
                    }
                }
            }
        }
        public void startSolveProcess(CrowdTask task)
        {

            Dictionary<string, object> para = new Dictionary<string, object>();
            CrowdTask crowdTask = new CrowdTask();
            crowdTask.taskName = task.taskName;
            crowdTask.taskDescription = task.taskDescription;
           
            crowdTask.taskType = TaskType.solveTask;

            para.Add("task", crowdTask);

            //创建实例对象
            WorkflowApplication currentWorkflowInstance = new WorkflowApplication(new solving(), para);

            //委托流程结束时候调用的方法
            currentWorkflowInstance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(solveWorkflowCompleted);

            //启动实例
            currentWorkflowInstance.Run();

            //继续绑定crowdTask 参数
            crowdTask.taskWorkflowId = currentWorkflowInstance.Id.ToString();

            //将这个任务插入到到数据库

            CrowdTaskService crowdTaskService = new CrowdTaskService();
            int result = crowdTaskService.insert(crowdTask);

            //更新每个实例的主工作流Id
            crowdTaskService.updateCrowdTaskMainTaskIdByWorkflowId(currentWorkflowInstance.Id.ToString());
            
            if (result == 1)
            {
                //将当前实例加入到分解任务集合中
                MyWorkflowInstance.setSolveWorkflowApplication(currentWorkflowInstance.Id.ToString(), currentWorkflowInstance);
            }
        }
        void solveWorkflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            MyWorkflowInstance.removeSolveWorkflowApplication(e.InstanceId.ToString());

            CrowdTask crowdTask = new CrowdTask();

            CrowdTaskService crowdTaskService = new CrowdTaskService();

            crowdTask = crowdTaskService.findCrowdTaskByWorkflowId(e.InstanceId.ToString());

            //将当前流程的解决结果写入数据库
            int result = crowdTaskService.saveSolveResult(crowdTask, (string)e.Outputs["out_solution"]);

            /*

            //通过当前解决任务的工作流ID ，获得该工作流的所有同一任务的不同工作流，如果都完成了则开启解决判断过程;
            int count = 0;

            ArrayList allSonCrowdTask = crowdTaskService.findAllSonCrowdTaskByParentTaskNameAndTaskDescriptionAndTaskType(crowdTask.taskName, crowdTask.taskDescription,crowdTask.taskType);

            foreach (CrowdTask ct in allSonCrowdTask)
            {
                WorkflowApplication wa = MyWorkflowInstance.getSolveWorkflowApplication(ct.taskWorkflowId);
                if (wa != null)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            if (count == ConstantDefine.solvingNumber)
            {
                //都已经解决完成，可以开始投票了
                //通过当前获得到的workflowId ,加载解决方案，然后保存在一个list里面，开启投票流程

                Dictionary<string,SolveResult> solveResutDic = new Dictionary<string,SolveResult>();
                
                //得到所有的解决结果
                    foreach (CrowdTask ct in allSonCrowdTask)
                    {
                      SolveResult sr = crowdTaskService.findSolveResultByWorkflowId(ct.taskWorkflowId);

                        solveResutDic.Add(ct.taskWorkflowId,sr);
                    }
                if(solveResutDic.Count!=0)
                {
                    //开启5个解决投票流程  工作流实例
                    for (int i = 0; i < ConstantDefine.solveVotingNumber; i++)
                    {
                        StartSubProcess ssp = new StartSubProcess();
                        ssp.startSolveVoteProcess(solveResutDic);
                    }
                }

            }
            */


            //如果所有的解决任务完成了。开启投票
            if (MyWorkflowInstance.getSolveWorkflowApplications().Count == 0)
            {
                ArrayList allSolveCompeletedCrowdTask = crowdTaskService.findAllSolveCompeletedCrowdTaskByMainTaskId(crowdTask.mainTaskId);
                //得到所有的解决结果
                foreach (SolveResult sr in allSolveCompeletedCrowdTask)
                {
                    //开启投票过程
                    Dictionary<string, SolveResult> solveResutDic = new Dictionary<string, SolveResult>();

                    ArrayList abc = crowdTaskService.finSolveResultByMainTaskIdAndTaskName(crowdTask.mainTaskId, sr.taskName);
                    foreach (SolveResult sdr in abc)
                    {
                        solveResutDic.Add(sdr.taskWorkflowId, sdr);
                    }
                    if (solveResutDic.Count != 0)
                    {
                        //开启5个解决投票流程  工作流实例
                        for (int i = 0; i < ConstantDefine.solveVotingNumber; i++)
                        {
                            StartSubProcess ssp = new StartSubProcess();
                            ssp.startSolveVoteProcess(solveResutDic);
                        }
                    }
                }

                MyWorkflowInstance.getWorkflowApplication(crowdTask.mainTaskId).ResumeBookmark(BookmarkName.Solving,null);

            }
        }

        public  void startSolveVoteProcess(Dictionary<string, SolveResult> solveResutDic)
        {
            //开启解决投票实例
            //创建输入参数
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("sovleResultDic", solveResutDic);

            //创建实例对象
            WorkflowApplication currentWorkflowInstance = new WorkflowApplication(new solveVoting(), para);

            //委托流程结束时候调用的方法
            currentWorkflowInstance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(solveVotingWorkflowCompleted);

            //启动实例
            currentWorkflowInstance.Run();

            CrowdTaskService crowdTaskService = new CrowdTaskService();

          

            CrowdTask crowdTask = new CrowdTask();
            crowdTask.taskName =  solveResutDic.Values.First().taskName;
            crowdTask.taskDescription = solveResutDic.Values.First().taskDescription;
            crowdTask.taskType = TaskType.solveVotingTask;
            crowdTask.taskWorkflowId = currentWorkflowInstance.Id.ToString();

            int result = crowdTaskService.insert(crowdTask);
            //更新每个实例的主工作流Id
            crowdTaskService.updateCrowdTaskMainTaskIdByWorkflowId(currentWorkflowInstance.Id.ToString());

            if (result == 1)
            {
                //将当前实例加入到分解任务集合中
                MyWorkflowInstance.setSolveVotingWorkflowApplication(currentWorkflowInstance.Id.ToString(), currentWorkflowInstance);
            }
        }

        private void solveVotingWorkflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
           //保存到解决投票表里面
            MyWorkflowInstance.removeSolveVotingWorkflowApplication(e.InstanceId.ToString());

            CrowdTask crowdTask = new CrowdTask();
          

            CrowdTaskService crowdTaskService = new CrowdTaskService();

            crowdTask = crowdTaskService.findCrowdTaskByWorkflowId(e.InstanceId.ToString());

            //将当前流程的投票的分解的工作流ID写入数据库
            int result = crowdTaskService.saveSolveVoteResult1(e.InstanceId.ToString(), (string)e.Outputs["out_bestSolutionWorkflowId"]);

            //如果所有的解决投票任务完成了。开启投票
            if (MyWorkflowInstance.getSolveVotingWorkflowApplications().Count == 0)
            {
                //更新得到最佳答案；

                ArrayList allSolveCompeletedCrowdTask = crowdTaskService.findAllSolveCompeletedCrowdTaskByMainTaskId(crowdTask.mainTaskId);
                //得到每一个解决任务的名字，然后根据名字和描述再去加载解决任务的ID，得到ID之后再去判断是不是最佳答案

                foreach (SolveResult sr in allSolveCompeletedCrowdTask)
                {
                    ArrayList al = crowdTaskService.finSolveResultByMainTaskIdAndTaskName(crowdTask.mainTaskId,sr.taskName);

                    int[] supportedNumber = new int[ConstantDefine.solvingNumber];
                    string[] supportedWorkflowId = new string[ConstantDefine.solvingNumber];
                    int i = 0;

                    foreach (SolveResult item in al)
                    {
                        //拿到每一个ID 当做supportedId，去数据库里面比对
                        supportedNumber[i]= crowdTaskService.getSolveVoteResultBySupportedId(item.taskWorkflowId);
                        supportedWorkflowId[i] = item.taskWorkflowId;
                        i++;
                    }
                    int maxNumber = supportedNumber[0];
                    string maxWorkflowId = supportedWorkflowId[0];

                    for (int j = 0; j < al.Count; j++)
                    {
                        if (supportedNumber[j] > maxNumber)
                        {
                            maxNumber = supportedNumber[j];
                            maxWorkflowId = supportedWorkflowId[j];
                        }
                    }

                    //找到了最佳答案，更新。
                    crowdTaskService.updateSolveResultBestAnswer(maxWorkflowId);
                }
                //更新书签
                MyWorkflowInstance.getWorkflowApplication(crowdTask.mainTaskId).ResumeBookmark(BookmarkName.SolveVoting, null);

                //生成分解树。
                crowdTaskService.writeDecomposeTree(crowdTask.mainTaskId);
            }
        } 
    }
}
