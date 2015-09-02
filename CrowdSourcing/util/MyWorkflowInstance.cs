using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrowdSourcing;
using System.Collections;

/// <summary>
/// MyWorkflowInstance 的摘要说明
/// </summary>
public class MyWorkflowInstance
{
	public MyWorkflowInstance()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private static Dictionary<string, WorkflowApplication> workflowApplicationInstances =new Dictionary<string,WorkflowApplication>();

    private static Dictionary<string, WorkflowApplication> decomposeWorkflowApplicationInstances = new Dictionary<string, WorkflowApplication>();


    private static Dictionary<string, WorkflowApplication> decomposeVotingWorkflowApplicationInstances = new Dictionary<string, WorkflowApplication>();

    private static Dictionary<string, WorkflowApplication> solveWorkflowApplicationInstances = new Dictionary<string, WorkflowApplication>();

    private static Dictionary<string, WorkflowApplication> solveVotingWorkflowApplicationInstances = new Dictionary<string, WorkflowApplication>();


    public static Dictionary<string, WorkflowApplication> getdecomposeWorkflowApplications()
    {
        return decomposeWorkflowApplicationInstances;
    }
    public static WorkflowApplication getDecomposeWorkflowApplication(String instanceId)
    {
        if (decomposeWorkflowApplicationInstances.ContainsKey(instanceId))
        {
            return decomposeWorkflowApplicationInstances[instanceId];

        }
        return null;
    }
    public static void setDecomposeWorkflowApplication(String instanceId, WorkflowApplication workflowApplication)
    {
        decomposeWorkflowApplicationInstances.Add(instanceId, workflowApplication);
    }
    public static void removeDecomposeWorkflowApplication(string instanceId)
    {
        decomposeWorkflowApplicationInstances.Remove(instanceId);
    }
    public static void updateDecomposeWorkflowApplication(string instanceId)
    {
        decomposeWorkflowApplicationInstances.Remove(instanceId);
        decomposeWorkflowApplicationInstances.Add(instanceId, null);
    }





    public static Dictionary<string, WorkflowApplication> getdecomposeVotingWorkflowApplications()
    {
        return decomposeVotingWorkflowApplicationInstances;
    }
    public static WorkflowApplication getDecomposeVotingWorkflowApplication(String instanceId)
    {
        if (decomposeVotingWorkflowApplicationInstances.ContainsKey(instanceId))
        {
            return decomposeVotingWorkflowApplicationInstances[instanceId];

        }
        return null;
    }
    public static void setDecomposeVotingWorkflowApplication(String instanceId, WorkflowApplication workflowApplication)
    {
        decomposeVotingWorkflowApplicationInstances.Add(instanceId, workflowApplication);
    }
    public static void removeVotingDecomposeWorkflowApplication(string instanceId)
    {
        decomposeVotingWorkflowApplicationInstances.Remove(instanceId);
    }




    public static Dictionary<string, WorkflowApplication> getSolveVotingWorkflowApplications()
    {
        return solveVotingWorkflowApplicationInstances;
    }
    public static WorkflowApplication getSolveVotingWorkflowApplication(String instanceId)
    {
        if (solveVotingWorkflowApplicationInstances.ContainsKey(instanceId))
        {
            return solveVotingWorkflowApplicationInstances[instanceId];

        }
        return null;
    }
    public static void setSolveVotingWorkflowApplication(String instanceId, WorkflowApplication workflowApplication)
    {
        solveVotingWorkflowApplicationInstances.Add(instanceId, workflowApplication);
    }
    public static void removeSolveVotingWorkflowApplication(string instanceId)
    {
        solveVotingWorkflowApplicationInstances.Remove(instanceId);
    }



















    public static System.Collections.Generic.Dictionary<string, WorkflowApplication> getWorkflowApplications()
    {
        return workflowApplicationInstances;
    }
    public static WorkflowApplication getWorkflowApplication(String instanceId)  
    {
        if(workflowApplicationInstances.ContainsKey(instanceId)){
            return workflowApplicationInstances[instanceId];

        }
        return null;
    }
    public static void setWorkflowApplication(String instanceId,WorkflowApplication workflowApplication)
    {
        workflowApplicationInstances.Add(instanceId, workflowApplication);
    }
    public static void removeWorkflowApplication(string instanceId)
    {
        workflowApplicationInstances.Remove(instanceId);
    }








    public static Dictionary<string, WorkflowApplication> getSolveWorkflowApplications()
    {
        return solveWorkflowApplicationInstances;
    }
    public static WorkflowApplication getSolveWorkflowApplication(String instanceId)
    {
        if (solveWorkflowApplicationInstances.ContainsKey(instanceId))
        {
            return solveWorkflowApplicationInstances[instanceId];

        }
        return null;
    }
    public static void setSolveWorkflowApplication(String instanceId, WorkflowApplication workflowApplication)
    {
        solveWorkflowApplicationInstances.Add(instanceId, workflowApplication);
    }
    public static void removeSolveWorkflowApplication(string instanceId)
    {
        solveWorkflowApplicationInstances.Remove(instanceId);
    }

















}