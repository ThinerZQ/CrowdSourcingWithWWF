using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrowdSourcing;
using System.Collections;

public partial class viewMyTask : System.Web.UI.Page
{
    CrowdTaskService crowdTaskService = null;
    string workflowId = null;
    public Queue qu = new Queue();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        crowdTaskService = new CrowdTaskService();
        workflowId =  Request.Params["workflowId"];
        CrowdTask mainTask = crowdTaskService.findCrowdTaskByWorkflowId(workflowId);
        String taskName = mainTask.taskName;
        String taskDescription = mainTask.taskDescription;
        TextBox1.Text = taskName;
        TextBox2.Text = taskDescription;
        TextBox3.Text = workflowId;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        /*
        CrowdTask mainTask = crowdTaskService.findCrowdTaskByWorkflowId(workflowId);


        ArrayList al_decomposeTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskType(mainTask.taskWorkflowId,TaskType.decomposeTask,mainTask.mainTaskId);

        ArrayList best_decomposeResult = new ArrayList();

        foreach (CrowdTask ct in al_decomposeTask)
        {
            //找到最佳解决方案
            ArrayList s = crowdTaskService.findDecomposeResultByWorkflowIdAndVote(ct.taskWorkflowId,mainTask.mainTaskId);
            if (s.Count != 0)
            {
                best_decomposeResult = s;
            }
        }
        //把最佳解决方案里面的简单任务找出来，再注明顺序。放入一个队列

        getSequence(best_decomposeResult,mainTask.mainTaskId);

        //得到解决结果队列
        string[] bestAnswerId= new string[qu.Count];
        int k = 0;
        foreach (string taskName in qu)
        {
           //根据s，加载解决结果，然后找出投票最多的结果，合并完成，显示出来
            ArrayList solveResult = crowdTaskService.findSolveResultByTaskName(taskName,mainTask.mainTaskId);
            int[] voteResult = new int[ConstantDefine.solvingNumber];
            string[] voteResultID = new string[ConstantDefine.solvingNumber];
            int i=0;
            foreach (SolveResult item in solveResult)
            {
                voteResult[i] = crowdTaskService.getSolveVoteResultBySupportedId(item.taskWorkflowId);
                voteResultID[i] = item.taskWorkflowId;
                i++;
            }
            int best = voteResult[0];
            string bestId = voteResultID[0];
            for (int j = 0; j < voteResult.Length; j++)
            {
                if (voteResult[j] > best)
                {
                    best = voteResult[j];
                    bestId = voteResultID[j];
                }
            }
            bestAnswerId[k] = bestId;
            k++;
        }
        string finallyAnswer = null;
        //查询，组成答案
        for (k = 0; k < bestAnswerId.Length; k++)
        {
            string answer = crowdTaskService.findBestAnswerByWorkflowId(bestAnswerId[k],mainTask.mainTaskId);
           //更新数据库设置为最佳答案：
            crowdTaskService.updateSolveResultBestAnswer(bestAnswerId[k]);
            finallyAnswer += answer+"        ///////           ";
        }

        answerTextBox.Text = finallyAnswer;
        answerPanel.Visible = true;

         * 
         * */


    }











    /*


    public void getSequence(ArrayList best_decomposeResult,string mainTaskId)
    {
        foreach (DecomposeResult dr in best_decomposeResult)
        {
            int setps = best_decomposeResult.Count;
            switch (dr.taskOrder)
            {
                //判断第一步是不是简单任务
                case "第一步":
                    if (dr.simple == "yes")
                    {
                        //写入一个有序的队列里面
                        string taskName = dr.taskName;
                        string taskDescription = dr.taskDescription;
                        //什么样的队列有序，入队列
                        qu.Enqueue(taskName);
                    }
                    else
                    {
                        //根据这个去查找它的分解
                        string taskWorkflowId = dr.workflow_id;
                        ArrayList thisDecomposeTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(taskWorkflowId, dr.taskName, TaskType.decomposeTask,mainTaskId);

                        ArrayList best_decomposeResult1 = new ArrayList();

                        foreach (CrowdTask ct in thisDecomposeTask)
                        {
                            //找到最佳解决方案
                            ArrayList s = crowdTaskService.findDecomposeResultByWorkflowIdAndVote(ct.taskWorkflowId,mainTaskId);
                            if (s.Count != 0)
                            {
                                best_decomposeResult1 = s;
                            }
                        }
                        //开始调用自己
                        getSequence(best_decomposeResult,mainTaskId);

                    }
                    break;
                case "第二步":
                    if (dr.simple == "yes")
                    {
                        //写入一个有序的队列里面
                        string taskName = dr.taskName;
                        string taskDescription = dr.taskDescription;
                        //什么样的队列有序，入队列
                        qu.Enqueue(taskName);
                    }
                    else
                    {
                        //根据这个去查找它的分解

                        string taskWorkflowId = dr.workflow_id;
                        ArrayList thisDecomposeTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(taskWorkflowId, dr.taskName, TaskType.decomposeTask,mainTaskId);

                        ArrayList best_decomposeResult1 = new ArrayList();

                        foreach (CrowdTask ct in thisDecomposeTask)
                        {
                            //找到最佳解决方案
                            ArrayList s = crowdTaskService.findDecomposeResultByWorkflowIdAndVote(ct.taskWorkflowId,mainTaskId);
                            if (s.Count != 0)
                            {
                                best_decomposeResult1 = s;
                            }
                        }
                        //开始调用自己
                        getSequence(best_decomposeResult,mainTaskId);

                    }
                    break;
                case "第三步":
                    if (dr.simple == "yes")
                    {
                        //写入一个有序的队列里面
                        string taskName = dr.taskName;
                        string taskDescription = dr.taskDescription;
                        //什么样的队列有序，入队列
                        qu.Enqueue(taskName);
                    }
                    else
                    {
                        //根据这个去查找它的分解

                        string taskWorkflowId = dr.workflow_id;
                        ArrayList thisDecomposeTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(taskWorkflowId, dr.taskName, TaskType.decomposeTask,mainTaskId);

                        ArrayList best_decomposeResult1 = new ArrayList();

                        foreach (CrowdTask ct in thisDecomposeTask)
                        {
                            //找到最佳解决方案
                            ArrayList s = crowdTaskService.findDecomposeResultByWorkflowIdAndVote(ct.taskWorkflowId,mainTaskId);
                            if (s.Count != 0)
                            {
                                best_decomposeResult1 = s;
                            }
                        }
                        //开始调用自己
                        getSequence(best_decomposeResult,mainTaskId);

                    }
                    break;
                case "第四步":
                    if (dr.simple == "yes")
                    {
                        //写入一个有序的队列里面
                        string taskName = dr.taskName;
                        string taskDescription = dr.taskDescription;
                        //什么样的队列有序，入队列
                        qu.Enqueue(taskName);
                    }
                    else
                    {
                        //根据这个去查找它的分解

                        string taskWorkflowId = dr.workflow_id;
                        ArrayList thisDecomposeTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(taskWorkflowId, dr.taskName, TaskType.decomposeTask,mainTaskId);

                        ArrayList best_decomposeResult1 = new ArrayList();

                        foreach (CrowdTask ct in thisDecomposeTask)
                        {
                            //找到最佳解决方案
                            ArrayList s = crowdTaskService.findDecomposeResultByWorkflowIdAndVote(ct.taskWorkflowId,mainTaskId);
                            if (s.Count != 0)
                            {
                                best_decomposeResult1 = s;
                            }
                        }
                        //开始调用自己
                         getSequence(best_decomposeResult,mainTaskId);

                    }
                    break;
                case "第五步":
                    if (dr.simple == "yes")
                    {
                        //写入一个有序的队列里面
                        string taskName = dr.taskName;
                        string taskDescription = dr.taskDescription;
                        //什么样的队列有序，入队列
                        qu.Enqueue(taskName);
                    }
                    else
                    {
                        //根据这个去查找它的分解

                        string taskWorkflowId = dr.workflow_id;
                        ArrayList thisDecomposeTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(taskWorkflowId, dr.taskName, TaskType.decomposeTask,mainTaskId);

                        ArrayList best_decomposeResult1 = new ArrayList();

                        foreach (CrowdTask ct in thisDecomposeTask)
                        {
                            //找到最佳解决方案
                            ArrayList s = crowdTaskService.findDecomposeResultByWorkflowIdAndVote(ct.taskWorkflowId,mainTaskId);
                            if (s.Count != 0)
                            {
                                best_decomposeResult1 = s;
                            }
                        }
                        //开始调用自己
                        getSequence(best_decomposeResult,mainTaskId);

                    }
                    break;
            }
        }
    }
     * */
}