using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrowdSourcing;
using System.Activities;

public partial class subTaskSolveVoting : System.Web.UI.Page
{
    CrowdTaskService crowdTaskService = null;
    String taskWorkflowId;
//   string taskParentWorkflowId;
    ArrayList list;
    protected void Page_Load(object sender, EventArgs e)
    {
        //根据传过来的工作流ID，加载对应的实例

        crowdTaskService = new CrowdTaskService();
        //taskParentWorkflowId = Request.Params["parentWorkflowId"];
        taskWorkflowId = Request.Params["taskWorkflowId"];

        //得到任务实例
        CrowdTask crowdTask = crowdTaskService.findCrowdTaskByWorkflowId(taskWorkflowId);


        TextBox1.Text = crowdTask.taskName;
        TextBox2.Text = crowdTask.taskDescription;




        //通过解决任务实例得到解决任务的同几个实例

        //不应该根据分解任务的个数来生成表格，应该根据分解结果的个数来生成表格
        list = crowdTaskService.findAllSonCrowdTaskByParentTaskNameAndTaskDescriptionAndTaskType(crowdTask.taskName,crowdTask.taskDescription, TaskType.solveTask,crowdTask.mainTaskId);

        foreach (CrowdTask ct in list)
        {
           SolveResult solveResult = crowdTaskService.findSolveResultByWorkflowId(ct.taskWorkflowId,crowdTask.mainTaskId);

            //创建显示解决结果的表格

            Table table = new Table();
            table.BorderWidth = 1;

            TableHeaderRow tableHeaderRow = new TableHeaderRow();

            TableHeaderCell tableHeaderCell1 = new TableHeaderCell();
            tableHeaderCell1.Text = "工作流ID：";

            TableHeaderCell tableHeaderCell2 = new TableHeaderCell();
            tableHeaderCell2.Text = ct.taskWorkflowId;


            TableHeaderCell tableHeaderCell3 = new TableHeaderCell();
            RadioButton radioButton = new RadioButton();
            radioButton.GroupName = "vote";
            radioButton.ID = ct.taskWorkflowId;

            tableHeaderCell3.Controls.Add(radioButton);

            tableHeaderRow.Cells.Add(tableHeaderCell1);
            tableHeaderRow.Cells.Add(tableHeaderCell2);
            tableHeaderRow.Cells.Add(tableHeaderCell3);


            table.Rows.Add(tableHeaderRow);
                TableRow tr = new TableRow();

                TableCell tc = new TableCell();
                tc.Text ="解决方案";

                TableCell tc1 = new TableCell();
                tc1.Text = solveResult.taskSolution;
                tr.Cells.Add(tc);
                tr.Cells.Add(tc1);
                table.Rows.Add(tr);

          
            panel.Controls.Add(table);
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //获取选中的值
        string bestSolutionWorkflowId = null;
        foreach (CrowdTask ct in list)
        {
            RadioButton rb = (RadioButton)this.FindControl(ct.taskWorkflowId);
        
                if (rb.Checked)
                {
                    bestSolutionWorkflowId = ct.taskWorkflowId;
                    break;
                }
        }
        //将选中的结果保存保存起来。
        WorkflowApplication wa = MyWorkflowInstance.getSolveVotingWorkflowApplication(taskWorkflowId);
        wa.ResumeBookmark(BookmarkName.SolveVoting, bestSolutionWorkflowId);
        //跳票完成跳转
        Server.Transfer("solveVoteCompeleted.aspx");
    }
}