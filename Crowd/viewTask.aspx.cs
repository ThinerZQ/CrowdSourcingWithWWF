using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities;
using System.Workflow.Runtime;
using System.Activities.Hosting;
using CrowdSourcing;
using System.Collections;
using System.Collections.ObjectModel;

public partial class viewTask : System.Web.UI.Page
{
    CrowdTaskService crowdTaskService = new CrowdTaskService();
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
         * 
         * 得到系统所有的工作流程实例，并且显示出来
         * 
         */
       

        //加载主任务
        //加载所有的主任务实例
        Dictionary<string, WorkflowApplication> mainTaskinstances = MyWorkflowInstance.getWorkflowApplications();
        int mainTaskCount = mainTaskinstances.Count;
        //加载单个的主任务实例
        ReadOnlyCollection<BookmarkInfo>[] mainTaskBookmarks = new ReadOnlyCollection<BookmarkInfo>[mainTaskCount];
        WorkflowApplication[] mainTaskInstance = new WorkflowApplication[mainTaskCount];
        string[] mainTaskBookmarkName = new string[mainTaskCount];


        CrowdTask[] mainTasks = new CrowdTask[mainTaskCount];

        int i = 0;
         foreach (KeyValuePair<string, WorkflowApplication> kvp in mainTaskinstances)
         {
             //得到每个主任务实例的书签信息
             mainTaskBookmarks[i] = kvp.Value.GetBookmarks();

             mainTasks[i] = crowdTaskService.findCrowdTaskByWorkflowId(kvp.Value.Id.ToString());
             int bookmarkCount = mainTaskBookmarks[i].Count;
             if (bookmarkCount == 1)
             {
                 mainTaskBookmarkName[i] = kvp.Value.GetBookmarks().First().BookmarkName;
             }
             else
             {
                 mainTaskBookmarkName[i] = "end";
             }
             mainTaskInstance[i] = kvp.Value;
             i++;
         }

        //创建显示主任务的表格
         for (int j = 0; j < mainTaskCount; j++)
         {
             TableRow tr = new TableRow();

             TableCell tc1 = new TableCell();
             tc1.Text = "任务名：";

             TableCell tc2 = new TableCell();

             HyperLink hl = new HyperLink();

             switch (mainTaskBookmarkName[j])
             {
                 case BookmarkName.WaitJudgement:

                     hl.NavigateUrl = "waitJudgement.aspx?taskWorkflowId=" + mainTasks[j].taskWorkflowId;
                     break;
                 case BookmarkName.Decomposing:
                     hl.NavigateUrl = "decomposing.aspx?&taskWorkflowId=" + mainTasks[j].taskWorkflowId;
                     break;
                 case BookmarkName.Solving:
                     hl.NavigateUrl = "solving.aspx";
                     break;
                 case BookmarkName.SolveVoting:
                     hl.NavigateUrl = "solveVoting.aspx";
                     break;
                 case BookmarkName.Merging:
                     hl.NavigateUrl = "subMerging.aspx";
                     break;

             }
             hl.Text = mainTasks[j].taskName + "  (  " + mainTaskBookmarkName[j] + "  )     工作流ID: " + mainTasks[j].taskWorkflowId;

             tc2.Controls.Add(hl);
             tr.Cells.Add(tc1);
             tr.Cells.Add(tc2);
             mainTaskTable.Rows.Add(tr);
         }



        //加载分解任务
        
      Dictionary<string, WorkflowApplication> decomposeInstances = MyWorkflowInstance.getdecomposeWorkflowApplications();

      int decomposeCount = decomposeInstances.Count;

       WorkflowApplication[] decomposeInstance = new WorkflowApplication[decomposeCount];

       ReadOnlyCollection<BookmarkInfo>[] decomposeBookmarks = new ReadOnlyCollection<BookmarkInfo>[decomposeCount];

      string[] decomposeBookmarkName = new string[decomposeCount];
      
      //需要分解的众包任务
      CrowdTask[] decomposeTasks = new CrowdTask[decomposeCount];

       i=0;
        foreach (KeyValuePair<string, WorkflowApplication> kvp in decomposeInstances)
        {
            decomposeBookmarks[i] = kvp.Value.GetBookmarks();

            decomposeTasks[i]=crowdTaskService.findCrowdTaskByWorkflowId(kvp.Key);

            int bookmarkCount = decomposeBookmarks[i].Count;
            if (bookmarkCount == 1)
            {
                decomposeBookmarkName[i] = kvp.Value.GetBookmarks().First().BookmarkName;
            }
            else
            {
                decomposeBookmarkName[i] = "end";
            }

          
            decomposeInstance[i]=kvp.Value;
            i++;
        }

        //创建显示分解任务的表格
        for (int j = 0; j < decomposeCount; j++)
        {
            TableRow tr = new TableRow();

            TableCell tc1 = new TableCell();
            tc1.Text = "任务名：";

            TableCell tc2 = new TableCell();

            HyperLink hl = new HyperLink();

            switch (decomposeBookmarkName[j])
            {
                    case BookmarkName.WaitJudgement:
                       
                         hl.NavigateUrl = "subTaskJudgement.aspx?taskWorkflowId=" + decomposeTasks[j].taskWorkflowId;
                        break;
                    case BookmarkName.Decomposing:
                        hl.NavigateUrl = "subTaskDecomposing.aspx?taskWorkflowId=" + decomposeTasks[j].taskWorkflowId;
                         break;
                }
            hl.Text = decomposeTasks[j].taskName+"  (  "+ decomposeBookmarkName[j]+ "  )     工作流ID: "+decomposeTasks[j].taskWorkflowId;

            tc2.Controls.Add(hl);
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
            decomposeTable.Rows.Add(tr);
        }




        //加载分解投票任务；
        Dictionary<string, WorkflowApplication> decomposeVotingInstances = MyWorkflowInstance.getdecomposeVotingWorkflowApplications();

        int decomposeVotingCount = decomposeVotingInstances.Count;
        WorkflowApplication[] decomposeVotingInstance = new WorkflowApplication[decomposeVotingCount];

        ReadOnlyCollection<BookmarkInfo>[] decomposeVotingBookmarks = new ReadOnlyCollection<BookmarkInfo>[decomposeVotingCount];
        string[] decomposeVotingBookmarkName = new string[decomposeVotingCount];


        //需要分解投票的众包任务
        CrowdTask[] decomposeVotingTasks = new CrowdTask[decomposeVotingCount];

        //父任务的问题投票
        i = 0;
        foreach (KeyValuePair<string, WorkflowApplication> kvp in decomposeVotingInstances)
        {
            decomposeVotingBookmarks[i] = kvp.Value.GetBookmarks();
            decomposeVotingTasks[i] = crowdTaskService.findCrowdTaskByWorkflowId(kvp.Key);
            int bookmarkCount = decomposeVotingBookmarks[i].Count;
            if (bookmarkCount == 1)
            {
                decomposeVotingBookmarkName[i] = kvp.Value.GetBookmarks().First().BookmarkName;
            }
            else
            {
                decomposeVotingBookmarkName[i] = "end";
            }


            decomposeVotingInstance[i] = kvp.Value;
            i++;
        }

        //创建分解投票问题的表格
        for (int j = 0; j < decomposeVotingCount; j++)
        {
            TableRow tr = new TableRow();

            TableCell tc1 = new TableCell();
            tc1.Text = "任务名：";

            TableCell tc2 = new TableCell();

            HyperLink hl = new HyperLink();

           // CrowdTask parentTask = crowdTaskService.findCrowdTaskByParentWorkflowIdAnd(decomposeVotingTasks[j].taskParentWorkflowId);

            switch (decomposeVotingBookmarkName[j])
            {
              

                case BookmarkName.DecomposeVoting:

                    hl.NavigateUrl = "subTaskDecomposeVoting.aspx?taskWorkflowId=" + decomposeVotingInstance[j].Id.ToString() + "&parentWorkflowId=" + decomposeVotingTasks[j].taskParentWorkflowId;
                    break;

            }
            hl.Text = decomposeVotingTasks[j].taskName + "    的分解方案投票 (  " + decomposeVotingBookmarkName[j] + "  ) ";
            //hl.Text = "分解投票";
            tc2.Controls.Add(hl);
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
            decomposeVotingTable.Rows.Add(tr);
        }




        //加载解决任务；
        Dictionary<string, WorkflowApplication> solveInstances = MyWorkflowInstance.getSolveWorkflowApplications();

        int solveCount = solveInstances.Count;
        WorkflowApplication[] solveInstance = new WorkflowApplication[solveCount];

        ReadOnlyCollection<BookmarkInfo>[] solveBookmarks = new ReadOnlyCollection<BookmarkInfo>[solveCount];
        string[] solveBookmarkName = new string[solveCount];


        //需要解决的的众包任务
        CrowdTask[] solveTasks = new CrowdTask[solveCount];

       
        i = 0;
        foreach (KeyValuePair<string, WorkflowApplication> kvp in solveInstances)
        {
            solveBookmarks[i] = kvp.Value.GetBookmarks();
            solveTasks[i] = crowdTaskService.findCrowdTaskByWorkflowId(kvp.Key);
            int bookmarkCount = solveBookmarks[i].Count;
            if (bookmarkCount == 1)
            {
                solveBookmarkName[i] = kvp.Value.GetBookmarks().First().BookmarkName;
            }
            else
            {
                solveBookmarkName[i] = "end";
            }


            solveInstance[i] = kvp.Value;
            i++;
        }

        //创建解决问题的表格
        for (int j = 0; j < solveCount; j++)
        {
            TableRow tr = new TableRow();

            TableCell tc1 = new TableCell();
            tc1.Text = "任务名：";

            TableCell tc2 = new TableCell();

            HyperLink hl = new HyperLink();

            //CrowdTask parentTask = crowdTaskService.findCrowdTaskByWorkflowId(solveTasks[j].taskParentWorkflowId);

            switch (solveBookmarkName[j])
            {


                case BookmarkName.Solving:

                    hl.NavigateUrl = "subTaskSolving.aspx?taskWorkflowId=" + solveInstance[j].Id.ToString();
                    break;
                default:

                    break;

            }
            hl.Text = solveTasks[j].taskName + "  (  " + solveBookmarkName[j] + "  ) ";
            //hl.Text = "分解投票";
            tc2.Controls.Add(hl);
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
           solveTable.Rows.Add(tr);

        }

        //加载解决投票任务；
        Dictionary<string, WorkflowApplication> solveVotingInstances = MyWorkflowInstance.getSolveVotingWorkflowApplications();

        int solveVotingCount = solveVotingInstances.Count;
        WorkflowApplication[] solveVotingInstance = new WorkflowApplication[solveVotingCount];

        ReadOnlyCollection<BookmarkInfo>[] solveVotingBookmarks = new ReadOnlyCollection<BookmarkInfo>[solveVotingCount];
        string[] solveVotingBookmarkName = new string[solveVotingCount];


        //需要解决投票的众包任务
        CrowdTask[] solveVotingTasks = new CrowdTask[solveVotingCount];

        //需要解决的众包任务的投票投票
        i = 0;
        foreach (KeyValuePair<string, WorkflowApplication> kvp in solveVotingInstances)
        {
            solveVotingBookmarks[i] = kvp.Value.GetBookmarks();
            solveVotingTasks[i] = crowdTaskService.findCrowdTaskByWorkflowId(kvp.Key);
            int bookmarkCount = solveVotingBookmarks[i].Count;
            if (bookmarkCount == 1)
            {
                solveVotingBookmarkName[i] = kvp.Value.GetBookmarks().First().BookmarkName;
            }
            else
            {
                solveVotingBookmarkName[i] = "end";
            }


            solveVotingInstance[i] = kvp.Value;
            i++;
        }

        //创建分解投票问题的表格
        for (int j = 0; j < solveVotingCount; j++)
        {
            TableRow tr = new TableRow();

            TableCell tc1 = new TableCell();
            tc1.Text = "任务名：";

            TableCell tc2 = new TableCell();

            HyperLink hl = new HyperLink();

           // CrowdTask parentTask = crowdTaskService.findCrowdTaskByWorkflowId(decomposeVotingTasks[j].taskParentWorkflowId);

            switch (solveVotingBookmarkName[j])
            {


                case BookmarkName.SolveVoting:

                    hl.NavigateUrl = "subTaskSolveVoting.aspx?taskWorkflowId=" + solveVotingInstance[j].Id.ToString();
                    break;

            }
            hl.Text = solveVotingTasks[j].taskName + "    的解决结果投票 (  " + solveVotingBookmarkName[j] + "  ) ";
            //hl.Text = "分解投票";
            tc2.Controls.Add(hl);
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
            solveVotingTable.Rows.Add(tr);

        }













    }
   
}