using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrowdSourcing;
using System.Collections;
using System.Activities;

public partial class subTaskDecomposeVoting : System.Web.UI.Page
{
    CrowdTaskService crowdTaskService = null;
    String taskWorkflowId;
    string taskParentWorkflowId;
    ArrayList list;
    protected void Page_Load(object sender, EventArgs e)
    {
        //根据传过来的工作流ID，加载对应的实例

        crowdTaskService = new CrowdTaskService();
        taskParentWorkflowId = Request.Params["parentWorkflowId"];
        taskWorkflowId = Request.Params["taskWorkflowId"];
        //得到需要分解任务实例
        CrowdTask crowdTask = crowdTaskService.findCrowdTaskByWorkflowId(taskWorkflowId);

        TextBox1.Text = crowdTask.taskName;
        TextBox2.Text = crowdTask.taskDescription;
        TextBox3.Text = crowdTask.taskWorkflowId;


        //根据当前投票任务的名字，来查找分解任务有哪些，在根据这些分解任务的ID，去decomposeResult 里面查找对应的结果
        list = crowdTaskService.findAllSonCrowdTaskByParentTaskNameAndTaskDescriptionAndTaskType(crowdTask.taskName, crowdTask.taskDescription, TaskType.decomposeTask,crowdTask.mainTaskId);

       

        foreach (CrowdTask ct in list)
        {
            ArrayList decomposeResult = crowdTaskService.findDecomposeResultByWorkflowId(ct.taskWorkflowId,crowdTask.mainTaskId);
            
            //创建显示分解结果的表格

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

          

            foreach (DecomposeResult dr in decomposeResult)
            {

                if (dr != null)
                {
                    table.Rows.Add(tableHeaderRow);
                }

            }
           
            foreach(DecomposeResult dr in decomposeResult){
                TableRow tr = new TableRow();

                TableCell tc = new TableCell();
                tc.Text =   dr.taskOrder;

                 TableCell tc1 = new TableCell();
                tc1.Text =   dr.taskName;

                  TableCell tc2 = new TableCell();
                tc2.Text =   dr.taskDescription;

                tr.Cells.Add(tc);
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                table.Rows.Add(tr);

            }
            panel.Controls.Add(table);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //获取选中的值
        string bestSolutionWorkflowId=null;
        foreach (CrowdTask ct in list)
        {
            RadioButton rb = (RadioButton)this.FindControl(ct.taskWorkflowId);
            ArrayList decomposeResult = crowdTaskService.findDecomposeResultByWorkflowId(ct.taskWorkflowId,ct.mainTaskId);
            if (decomposeResult.Count != 0)
            {
                if (rb.Checked)
                {
                    bestSolutionWorkflowId = ct.taskWorkflowId;
                    break;
                }
            }
           
        }
        //将选中的结果保存保存起来。
        WorkflowApplication wa = MyWorkflowInstance.getDecomposeVotingWorkflowApplication(taskWorkflowId);


        wa.ResumeBookmark(BookmarkName.DecomposeVoting,bestSolutionWorkflowId);


        //跳票完成跳转
        Server.Transfer("decomposeVoteCompeleted.aspx");
    }
}