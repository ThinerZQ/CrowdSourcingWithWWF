using CrowdSourcing;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class subTaskJudgement : System.Web.UI.Page
{
    string taskWorkflowId;
  
    CrowdTaskService crowdTaskService = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        crowdTaskService = new CrowdTaskService();
        CrowdTask crowdTask = crowdTaskService.findCrowdTaskByWorkflowId(Request.Params["taskWorkflowId"]);

        taskWorkflowId = crowdTask.taskWorkflowId;

        TextBox1.Text = crowdTask.taskName;

        TextBox2.Text = crowdTask.taskDescription;
        TextBox3.Text = crowdTask.taskWorkflowId;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string answer = "";

        if (RadioButton1.Checked == true)
        {
            answer = "yes";
        }
        else
        {
            answer = "no";
        }
        WorkflowApplication instance = MyWorkflowInstance.getDecomposeWorkflowApplication(taskWorkflowId);

        instance.ResumeBookmark(BookmarkName.WaitJudgement, answer);

        if (answer == "yes")
        {
            //流程结束，不用判断
            Server.Transfer("judgeCompleted.aspx");
        }
        else
        {
            //跳转到分解界面
            Server.Transfer("subTaskDecomposing.aspx?taskWorkflowId="+taskWorkflowId);
        }
       

        
    }
}