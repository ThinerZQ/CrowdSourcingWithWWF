using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrowdSourcing;
using System.Activities;

public partial class subTaskSolving : System.Web.UI.Page
{
    CrowdTaskService crowdTaskService = null;
    String taskWorkflowId;
    CrowdTask currentCrowdTask;

    protected void Page_Load(object sender, EventArgs e)
    {
        taskWorkflowId = Request.Params["taskWorkflowId"];
        crowdTaskService = new CrowdTaskService();
        currentCrowdTask = crowdTaskService.findCrowdTaskByWorkflowId(taskWorkflowId);
        TextBox1.Text = currentCrowdTask.taskName;
        TextBox2.Text = currentCrowdTask.taskDescription;
        TextBox3.Text = taskWorkflowId;




    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string solution = TextBox4.Text;
        WorkflowApplication instance = MyWorkflowInstance.getSolveWorkflowApplication(taskWorkflowId);

        instance.ResumeBookmark(BookmarkName.Solving, solution);

        //跳转到分解完成页面
        Server.Transfer("solveCompeleted.aspx");
    }
}