using CrowdSourcing;
using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 

public partial class subTaskDecomposing : System.Web.UI.Page
{
   
    CrowdTaskService crowdTaskService = null;
    String taskWorkflowId;
    CrowdTask currentCrowdTask;
    string step;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        taskWorkflowId = Request.Params["taskWorkflowId"];
        crowdTaskService = new CrowdTaskService();
        currentCrowdTask = crowdTaskService.findCrowdTaskByWorkflowId(taskWorkflowId);
        TextBox1.Text = currentCrowdTask.taskName;
        TextBox2.Text = currentCrowdTask.taskDescription; 
        TextBox3.Text = taskWorkflowId;

        if (!IsPostBack)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("请选择分解步数");
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            DropDownList1.DataSource = arrayList;
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        step = this.DropDownList1.SelectedItem.Value;
       // number = Convert.ToInt32(step);
        tb_step.Text = step;
        panel1.Visible = false;
        panel2.Visible = false;
        panel3.Visible = false;
        panel4.Visible = false;
        panel5.Visible = false;
        Button1.Visible = false;
      //  Response.Write("sssssssssssssssss    "+step);
        switch (step)
        {
            case "2":
                Response.Write("");
                panel1.Visible = true;
                panel2.Visible = true;
                Button1.Visible = true;
                break;
            case "3":
                  panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                Button1.Visible = true;
                break;
            case "4":
                  panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                Button1.Visible = true;
                break;
            case "5":
                  panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                Button1.Visible = true;
                break;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ArrayList arrayList = new ArrayList();
        string steps = tb_step.Text;
        int number = Convert.ToInt32(steps);
        CrowdTask[] crowdTasks = new CrowdTask[number];
        DecomposeResult[] decomposeResults = new DecomposeResult[number];


        for (int i = 0; i < number; i++)
        {
            CrowdTask ct = new CrowdTask();
            crowdTasks[i] = ct;
            DecomposeResult dr = new DecomposeResult();
            decomposeResults[i] = dr;
        }  
        switch(steps){
            case "2":
               
                /*
                    crowdTasks[0].taskName = taskName_1.Text;
                    crowdTasks[0].taskDescription = taskDescription_1.Text;
                    crowdTasks[1].taskName = taskName_2.Text;
                    crowdTasks[1].taskDescription = taskDescription_2.Text;
                */
               
                    decomposeResults[0].taskName = taskName_1.Text;
                    decomposeResults[0].taskDescription = taskDescription_1.Text;
                    decomposeResults[0].taskOrder = "第一步";
                    decomposeResults[0].workflow_id = taskWorkflowId;
                    decomposeResults[0].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[0].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[1].taskName = taskName_2.Text;
                    decomposeResults[1].taskDescription = taskDescription_2.Text;
                    decomposeResults[1].taskOrder = "第二步";
                    decomposeResults[1].workflow_id = taskWorkflowId;
                    decomposeResults[1].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[1].mainTaskId = currentCrowdTask.mainTaskId;

                    for (int i = 0; i < number; i++)
                    {
                        arrayList.Add(decomposeResults[i]);
                    } 
                break;
            case "3":
                 
                /*
                    crowdTasks[0].taskName = taskName_1.Text;
                    crowdTasks[0].taskDescription = taskDescription_1.Text;
                    crowdTasks[1].taskName = taskName_2.Text;
                    crowdTasks[1].taskDescription = taskDescription_2.Text;     
                    crowdTasks[2].taskName = taskName_3.Text;
                    crowdTasks[2].taskDescription = taskDescription_3.Text;  
                */

                   decomposeResults[0].taskName = taskName_1.Text;
                    decomposeResults[0].taskDescription = taskDescription_1.Text;
                    decomposeResults[0].taskOrder = "第一步";
                    decomposeResults[0].workflow_id = taskWorkflowId;
                    decomposeResults[0].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[0].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[1].taskName = taskName_2.Text;
                    decomposeResults[1].taskDescription = taskDescription_2.Text;
                    decomposeResults[1].taskOrder = "第二步";
                    decomposeResults[1].workflow_id = taskWorkflowId;
                    decomposeResults[1].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[1].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[2].taskName = taskName_3.Text;
                    decomposeResults[2].taskDescription = taskDescription_3.Text;
                    decomposeResults[2].taskOrder = "第三步";
                    decomposeResults[2].workflow_id = taskWorkflowId;
                    decomposeResults[2].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[2].mainTaskId = currentCrowdTask.mainTaskId;
                    for (int i = 0; i < number; i++)
                    {
                        arrayList.Add(decomposeResults[i]);
                    } 
                break;
            case "4":
                /*
                  crowdTasks[0].taskName = taskName_1.Text;
                    crowdTasks[0].taskDescription = taskDescription_1.Text;
                    crowdTasks[1].taskName = taskName_2.Text;
                    crowdTasks[1].taskDescription = taskDescription_2.Text;     
                 crowdTasks[2].taskName = taskName_3.Text;
                    crowdTasks[2].taskDescription = taskDescription_3.Text;  
                    crowdTasks[3].taskName = taskName_4.Text;
                    crowdTasks[3].taskDescription = taskDescription_4.Text;  
                */
                      decomposeResults[0].taskName = taskName_1.Text;
                    decomposeResults[0].taskDescription = taskDescription_1.Text;
                    decomposeResults[0].taskOrder = "第一步";
                    decomposeResults[0].workflow_id = taskWorkflowId;
                    decomposeResults[0].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[0].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[1].taskName = taskName_2.Text;
                    decomposeResults[1].taskDescription = taskDescription_2.Text;
                    decomposeResults[1].taskOrder = "第二步";
                    decomposeResults[1].workflow_id = taskWorkflowId;
                    decomposeResults[1].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[1].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[2].taskName = taskName_3.Text;
                    decomposeResults[2].taskDescription = taskDescription_3.Text;
                    decomposeResults[2].taskOrder = "第三步";
                    decomposeResults[2].workflow_id = taskWorkflowId;
                    decomposeResults[2].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[2].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[3].taskName = taskName_4.Text;
                    decomposeResults[3].taskDescription = taskDescription_4.Text;
                    decomposeResults[3].taskOrder = "第四步";
                    decomposeResults[3].workflow_id = taskWorkflowId;
                    decomposeResults[3].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[3].mainTaskId = currentCrowdTask.mainTaskId;
                    for (int i = 0; i < number; i++)
                    {
                        arrayList.Add(decomposeResults[i]);
                    } 
                break;
            case "5":
                /*
                  crowdTasks[0].taskName = taskName_1.Text;
                    crowdTasks[0].taskDescription = taskDescription_1.Text;
                    crowdTasks[1].taskName = taskName_2.Text;
                    crowdTasks[1].taskDescription = taskDescription_2.Text;     
                 crowdTasks[2].taskName = taskName_3.Text;
                    crowdTasks[2].taskDescription = taskDescription_3.Text;  
                    crowdTasks[3].taskName = taskName_4.Text;
                    crowdTasks[3].taskDescription = taskDescription_4.Text;   
                    crowdTasks[4].taskName = taskName_5.Text;
                    crowdTasks[4].taskDescription = taskDescription_5.Text; 
                */

                
                  
                      decomposeResults[0].taskName = taskName_1.Text;
                    decomposeResults[0].taskDescription = taskDescription_1.Text;
                    decomposeResults[0].taskOrder = "第一步";
                    decomposeResults[0].workflow_id = taskWorkflowId;
                    decomposeResults[0].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[0].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[1].taskName = taskName_2.Text;
                    decomposeResults[1].taskDescription = taskDescription_2.Text;
                    decomposeResults[1].taskOrder = "第二步";
                    decomposeResults[1].workflow_id = taskWorkflowId;
                    decomposeResults[1].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[1].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[2].taskName = taskName_3.Text;
                    decomposeResults[2].taskDescription = taskDescription_3.Text;
                    decomposeResults[2].taskOrder = "第三步";
                    decomposeResults[2].workflow_id = taskWorkflowId;
                    decomposeResults[2].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[2].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[3].taskName = taskName_4.Text;
                    decomposeResults[3].taskDescription = taskDescription_4.Text;
                    decomposeResults[3].taskOrder = "第四步";
                    decomposeResults[3].workflow_id = taskWorkflowId;
                    decomposeResults[3].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[3].mainTaskId = currentCrowdTask.mainTaskId;

                    decomposeResults[4].taskName = taskName_5.Text;
                    decomposeResults[4].taskDescription = taskDescription_5.Text;
                    decomposeResults[4].taskOrder = "第五步";
                    decomposeResults[4].workflow_id = taskWorkflowId;
                    decomposeResults[4].parent_workflow_id = currentCrowdTask.taskParentWorkflowId;
                    decomposeResults[4].mainTaskId = currentCrowdTask.mainTaskId;


                    for (int i = 0; i < number; i++)
                    {
                        arrayList.Add(decomposeResults[i]);
                    } 

                break;
        }

        WorkflowApplication instance = MyWorkflowInstance.getDecomposeWorkflowApplication(taskWorkflowId);

        instance.ResumeBookmark(BookmarkName.Decomposing, arrayList);

        //跳转到分解完成页面
        Server.Transfer("decomposeCompeleted.aspx");


        
    }
}