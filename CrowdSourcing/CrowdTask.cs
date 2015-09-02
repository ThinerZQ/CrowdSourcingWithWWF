using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Task 的摘要说明
/// </summary>


namespace CrowdSourcing { 
public class CrowdTask
{
      public string taskName{get;set;}
      public string taskDescription { get; set; }

      public string taskType { get; set; }
      public string taskWorkflowId { get; set; }
      public string taskParentWorkflowId { get; set; }

      public Object taskSolution { get; set; }

      public string mainTaskId { get; set; }

	public CrowdTask()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
      
	}
    public CrowdTask(string taskName, string taskDescription)
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
        this.taskDescription = taskDescription;
        this.taskName = taskName;
      
	}

   
}
}