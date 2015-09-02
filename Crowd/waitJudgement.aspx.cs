using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrowdSourcing;

public partial class waitJudgement : System.Web.UI.Page
{
    CrowdTaskService crowdTaskService = null;
    string workflow_id = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        crowdTaskService = new CrowdTaskService();

        CrowdTask mainTask = crowdTaskService.findCrowdTaskByWorkflowId(Request.Params["taskWorkflowId"]);

        workflow_id = mainTask.taskWorkflowId;

        String taskName = mainTask.taskName;
        String taskDescription = mainTask.taskDescription;
        TextBox1.Text = taskName;
        TextBox2.Text = taskDescription;
        TextBox3.Text = workflow_id;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string answer ="";

        if (RadioButton1.Checked == true)
        {
            answer = "yes";
        }
        else
        {
            answer = "no";
        }
        Dictionary<string, WorkflowApplication> instances = MyWorkflowInstance.getWorkflowApplications();

      

        WorkflowApplication wa = MyWorkflowInstance.getWorkflowApplication(workflow_id);

        wa.ResumeBookmark(BookmarkName.WaitJudgement,answer);



        //跳转到分解完成界面

        Server.Transfer("judgeCompleted.aspx");
        


    }


}