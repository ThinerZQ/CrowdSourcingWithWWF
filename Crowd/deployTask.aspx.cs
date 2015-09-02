using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities; 
using System.Workflow.Runtime;
using CrowdSourcing;
using System.Workflow.Runtime.Hosting;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    public CrowdTaskService crowdTaskService;
    protected void Page_Load(object sender, EventArgs e)
    {
        String username = Request.Params["username"];
        TextBox3.Text = "欢迎你，" + username;
    } 

    protected void Button1_Click(object sender, EventArgs e)

    {
     
           //设置参数
            Dictionary<string,object> para=new  Dictionary<string, object>();
            CrowdTask task = new CrowdTask(TextBox1.Text,TextBox2.Text);
            para.Add("task", task);

            //启动工作流
           WorkflowApplication crowdsourcing = new WorkflowApplication(new mainTask1(),para);
           task.taskType= TaskType.mainTask;
           crowdsourcing.Run();
           task.taskWorkflowId = crowdsourcing.Id.ToString();
           try
           {
               crowdTaskService = new CrowdTaskService();
               int result = crowdTaskService.insert(task);
               if(result==1){
                   //插入成功，保存对应的工作流实例
                   MyWorkflowInstance.setWorkflowApplication(crowdsourcing.Id.ToString(),crowdsourcing);
                   crowdTaskService.mainTaskSetCrowdTaskMainTaskIdByWorkflowId(crowdsourcing.Id.ToString());
                   Server.Transfer("viewMyTask.aspx?workflowId=" + task.taskWorkflowId);
               }
           }
           catch (Exception exception)
           {
               throw exception ;
           }
          
        
    }































    

}