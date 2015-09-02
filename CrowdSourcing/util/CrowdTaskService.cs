using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrowdSourcing;
using System.Data.SqlClient;
using System.Collections;

public class CrowdTaskService
{
    public SqlConnection conn;
	public CrowdTaskService()
	{
        conn = DbHelper.getSqlConnection();
	}
    public int insert(CrowdTask crowdTask)
    {
        int result = 0;
        SqlCommand com=null;
        try
        {
            conn.Open();
            string sql = string.Format("insert into crowdTask(taskName,taskDescription,taskType,workflow_id,parent_workflow_id) values('{0}','{1}','{2}','{3}','{4}')", crowdTask.taskName, crowdTask.taskDescription, crowdTask.taskType, crowdTask.taskWorkflowId, crowdTask.taskParentWorkflowId);
            com = new SqlCommand(sql, conn);
            result = com.ExecuteNonQuery();
        }catch(Exception e){
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return result;
    }
    public CrowdTask findCrowdTaskByWorkflowId(string workflow_id)
    {
        CrowdTask crowdTask = new CrowdTask();
        SqlCommand com = null;
        try
        {
            conn.Open();
            //查询到这个数据，将数据填入crowdtask
            string sql = string.Format("select * from crowdTask where workflow_id='{0}'",workflow_id);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                crowdTask.taskName = dr[1].ToString();
                crowdTask.taskDescription = dr[2].ToString();
                crowdTask.taskType = dr[3].ToString();
                crowdTask.taskWorkflowId = dr[4].ToString();
                crowdTask.taskParentWorkflowId = dr[5].ToString();
                crowdTask.mainTaskId = dr[6].ToString();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return crowdTask;
    }
    public CrowdTask findCrowdTaskByParentWorkflowId(string parent_workflow_id)
    {
        CrowdTask crowdTask = new CrowdTask();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = "";
            com = new SqlCommand(sql, conn);
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return crowdTask;
    }
    public ArrayList findCrowdTaskByParentWorkflowIdAndTaskType(string parent_workflow_id,string tasktype,string mainTaskId)
    {
        ArrayList arrayList = new ArrayList();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from crowdTask where parent_workflow_id='{0}' and taskType='{1}' and mainTaskId='{2}'", parent_workflow_id,tasktype,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                CrowdTask crowdTask = new CrowdTask();
                crowdTask.taskName = dr["taskName"].ToString();
                crowdTask.taskDescription = dr["taskDescription"].ToString();
                crowdTask.taskType = dr["taskType"].ToString();
                crowdTask.taskWorkflowId = dr["workflow_id"].ToString();
                crowdTask.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                crowdTask.mainTaskId = dr["mainTaskId"].ToString();
                arrayList.Add(crowdTask);
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return arrayList;
    }
    public ArrayList findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(string parent_workflow_id, string taskName,string taskType,string mainTaskId)
    {
        ArrayList arrayList = new ArrayList();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from crowdTask where parent_workflow_id='{0}' and taskType='{1}' and taskName='{2}' and mainTaskId='{3}'", parent_workflow_id,taskType,taskName,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                CrowdTask crowdTask = new CrowdTask();
                crowdTask.taskName = dr["taskName"].ToString();
                crowdTask.taskDescription = dr["taskDescription"].ToString();
                crowdTask.taskType = dr["taskType"].ToString();
                crowdTask.taskWorkflowId = dr["workflow_id"].ToString();
                crowdTask.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                crowdTask.mainTaskId = dr["mainTaskId"].ToString();
                arrayList.Add(crowdTask);
            }
           
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return arrayList;
    }
    public ArrayList findAllSonCrowdTaskByParentWorkflowIdAndTaskName(string parent_workflow_id, string taskName,string mainTaskId)
    {
        ArrayList arrayList = new ArrayList();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from crowdTask where parent_workflow_id='{0}' and taskName='{1}' and mainTaskId='{2}'", parent_workflow_id,taskName,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                CrowdTask crowdTask = new CrowdTask();
                crowdTask.taskName = dr["taskName"].ToString();
                crowdTask.taskDescription = dr["taskDescription"].ToString();
                crowdTask.taskType = dr["taskType"].ToString();
                crowdTask.taskWorkflowId = dr["workflow_id"].ToString();
                crowdTask.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                crowdTask.mainTaskId = dr["mainTaskId"].ToString();
                arrayList.Add(crowdTask);
            }
           
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return arrayList;
    }
    public ArrayList findAllSonCrowdTaskByParentTaskNameAndTaskDescriptionAndTaskType(string taskName, string taskDescription,string taskType,string mainTaskId)
    {
        ArrayList arrayList = new ArrayList();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from crowdTask where taskName='{0}' and taskDescription='{1}' and taskType='{2}' and mainTaskId='{3}'", taskName, taskDescription,taskType,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                CrowdTask crowdTask = new CrowdTask();
                crowdTask.taskName = dr["taskName"].ToString();
                crowdTask.taskDescription = dr["taskDescription"].ToString();
                crowdTask.taskType = dr["taskType"].ToString();
                crowdTask.taskWorkflowId = dr["workflow_id"].ToString();
                crowdTask.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                crowdTask.mainTaskId = dr["mainTaskId"].ToString();
                arrayList.Add(crowdTask);
            }
           
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return arrayList;
         }

    internal int updateCrowdTaskByWorkflowId(string workflow_id)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            conn.BeginTransaction();
            string sql = "";
            com = new SqlCommand(sql, conn);
            result = com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return result;
    }

    public int saveDecomposeResult(string workflow_id, ArrayList arrayList)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            if (arrayList != null)
            {
                foreach (DecomposeResult dr in arrayList)
                {
                    string sql = string.Format("insert into decomposeResult(taskName,taskDescription,taskOrder,workflow_id,parent_workflow_id,mainTaskId) values('{0}','{1}','{2}','{3}','{4}','{5}')", dr.taskName, dr.taskDescription, dr.taskOrder, dr.workflow_id, dr.parent_workflow_id,dr.mainTaskId);
                    com = new SqlCommand(sql, conn);
                    int k = com.ExecuteNonQuery();
                    result += k;
                }
            }
            else
            {
                //有一个人认为是简单任务
            }
           
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
          
        }
        return result;
    }

    public ArrayList findDecomposeResultByWorkflowId(string workflow_id,string mainTaskId)
    {
        ArrayList arrayList = new ArrayList();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from decomposeResult where workflow_id='{0}' and mainTaskId='{1}'", workflow_id,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DecomposeResult decomposeResult = new DecomposeResult();
                decomposeResult.taskName = dr["taskName"].ToString();
                decomposeResult.taskDescription = dr["taskDescription"].ToString();
                decomposeResult.taskOrder = dr["taskOrder"].ToString();
                decomposeResult.workflow_id = dr["workflow_id"].ToString();
                decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();
                decomposeResult.vote = dr["vote"].ToString();
                decomposeResult.simple = dr["simples"].ToString();
                decomposeResult.mainTaskId=dr["mainTaskId"].ToString();
                arrayList.Add(decomposeResult);
            }
            com = new SqlCommand(sql, conn);
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return arrayList;
    }
    public Dictionary<string,ArrayList> findAllDecomposeResultByParentWorkflowId(string parent_workflow_id,string mainTaskId)
    {
        Dictionary<string, ArrayList> dic = new Dictionary<string, ArrayList>();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from decomposeResult where parent_workflow_id='{0}' and mainTaskId='{1}'", parent_workflow_id,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            ArrayList arrayList = new ArrayList();
            while (dr.Read())
            {
                DecomposeResult decomposeResult = new DecomposeResult();
                decomposeResult.taskName = dr["taskName"].ToString();
                decomposeResult.taskDescription = dr["taskDescription"].ToString();
                decomposeResult.taskOrder = dr["taskOrder"].ToString();
                decomposeResult.workflow_id = dr["workflow_id"].ToString();
                decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();
                decomposeResult.simple = dr["simples"].ToString();
                decomposeResult.mainTaskId = dr["mainTaskId"].ToString();
                arrayList.Add(decomposeResult);
            }
            ArrayList list = new ArrayList();
            for (int i=0;i<arrayList.Count-1;i++)
            {
                DecomposeResult dr1 = arrayList[i] as DecomposeResult;
                DecomposeResult dr2 = arrayList[i+1] as DecomposeResult;

                if (dr1.workflow_id == dr2.workflow_id)
                {
                    list.Add(dr1);
                    list.Add(dr2);
                }

            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return dic;
    }

    public int saveDecomposeVoteResult(string workflow_id, string supportWorklfow_id)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from crowdTask where workflow_id='{0}'", workflow_id);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            string parent_workflow_id=null;
            while (dr.Read())
            {
               parent_workflow_id = dr["parent_workflow_id"].ToString();
            }
            dr.Dispose();
            com.Dispose();
            sql = string.Format("insert into decomposeVoteResult values('{0}','{1}','{2}')",workflow_id, supportWorklfow_id, parent_workflow_id);
            com = new SqlCommand(sql, conn);
           result = com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return result;
    }
   

    public Dictionary<string,int> getDecomposeVoteResult(string parent_workflow_id)
    {
        SqlCommand com = null;
        int[] vote_numbers= new int[ConstantDefine.divideNumber];
        string[] supportWorkflowId = new string[ConstantDefine.divideNumber];
        int max = vote_numbers[0];
        string maxWithWorkflowId = null;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        try
        {
            conn.Open();
            string sql = string.Format("select count(*) as vote_number,supportWorkflowId  from decomposeVoteResult where parent_workflow__id='{0}' group by supportWorkflowId", parent_workflow_id);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                vote_numbers[i] = Convert.ToInt32(dr["vote_number"].ToString());
                supportWorkflowId[i] = dr["supportWorkflowId"].ToString();
                i++;
            }
           
            for (int j = 0; j <i; j++)
            {
                if (vote_numbers[j] > max)
                {
                    max = vote_numbers[j];
                    maxWithWorkflowId = supportWorkflowId[j];
                }

            }
            dic.Add(maxWithWorkflowId,max);

            //可以再这里将分解投票结果，标记到decomposeResult表里面
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return dic;
    }
    public Dictionary<string, int> findSupportThisIdNumber(string workflow_id)
    {
        SqlCommand com = null;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        try
        {
            conn.Open();
            string sql = string.Format("select count(*) as vote_number,supportWorkflowId  from decomposeVoteResult where supportWorkflowId='{0}' group by supportWorkflowId", workflow_id);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
           // int i = 0;
            while (dr.Read())
            {
                int voteNumbers = Convert.ToInt32(dr["vote_number"].ToString());
                string votedWorkflowId = dr["supportWorkflowId"].ToString();
                dic.Add(votedWorkflowId, voteNumbers);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return dic;

    }
    public Dictionary<string, ArrayList> getAllNeedSolvedCrowTaskInDecomposeResult(string mainTaskId)
    {
      //  int result = 0;
        SqlCommand com = null;
        Dictionary<string, ArrayList> dic = new Dictionary<string, ArrayList>();
        try
        {
            conn.Open();
            string sql = string.Format("select wrokflow_id  from decomposeResult where simples='{0}' and mainTaskId='{1}' group by workflow_id", "yes",mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ArrayList al = new ArrayList();
                string sql2 = string.Format("select *  from decomposeResult where simples='{0}' and workflow_id='{1}' and mainTaskId='{2}'", "yes",dr["workflow_id"].ToString(),mainTaskId);
                SqlConnection sqlconnection = DbHelper.getSqlConnection();
                SqlCommand sc = new SqlCommand(sql2,sqlconnection);
                SqlDataReader dr1 = sc.ExecuteReader();
                while (dr1.Read())
                {
                    DecomposeResult decomposeResult = new DecomposeResult();
                    decomposeResult.taskName = dr["taskName"].ToString();
                    decomposeResult.taskDescription = dr["taskDescription"].ToString();
                    decomposeResult.taskOrder = dr["taskOrder"].ToString();
                    decomposeResult.workflow_id = dr["workflow_id"].ToString();
                    decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();
                    decomposeResult.vote = dr["vote"].ToString();
                    decomposeResult.simple = dr["simples"].ToString();
                    decomposeResult.mainTaskId = dr["mainTaskId"].ToString();
                    al.Add(decomposeResult);
                }
                dic.Add(dr["workflow_id"].ToString(),al);
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return dic;
    
    }




    public ArrayList getAllNeedSolvedCrowTaskInDecomposeResult1(string mainTaskId)
    {
        //  int result = 0;
        SqlCommand com = null;
        ArrayList list = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select *  from decomposeResult where simples='{0}' and mainTaskId='{1}'", "yes",mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
            
                    DecomposeResult decomposeResult = new DecomposeResult();
                    decomposeResult.taskName = dr["taskName"].ToString();
                    decomposeResult.taskDescription = dr["taskDescription"].ToString();
                    decomposeResult.taskOrder = dr["taskOrder"].ToString();
                    decomposeResult.workflow_id = dr["workflow_id"].ToString();
                    decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();
                    decomposeResult.vote = dr["vote"].ToString();
                    decomposeResult.simple = dr["simples"].ToString();
                    decomposeResult.mainTaskId = dr["mainTaskId"].ToString();
                    list.Add(decomposeResult);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return list;
    }



    public ArrayList findAllSolveCompeletedCrowdTaskByMainTaskId(string mainTaskId)
    {
        //  int result = 0;
        SqlCommand com = null;
        ArrayList list = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select distinct taskName  from solveResult where mainTaskId='{0}'",mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                    SolveResult solveResult = new SolveResult();
                    solveResult.taskName = dr["taskName"].ToString();
                /*
                    solveResult.taskDescription = dr["taskDescription"].ToString();
                    solveResult.taskWorkflowId = dr["workflow_id"].ToString();
                    solveResult.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                    solveResult.taskSolution = dr["solutions"].ToString();
                 * */
                    list.Add(solveResult);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return list;
    }


    public ArrayList finSolveResultByMainTaskIdAndTaskName(string mainTaskId,string taskName)
    {
        //  int result = 0;
        SqlCommand com = null;
        ArrayList list = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select *  from solveResult where mainTaskId='{0}' and taskName='{1}'",mainTaskId ,taskName);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                    SolveResult solveResult = new SolveResult();
                    solveResult.taskName = dr["taskName"].ToString();
             
                    solveResult.taskDescription = dr["taskDescription"].ToString();
                    solveResult.taskWorkflowId = dr["workflow_id"].ToString();
                    solveResult.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                    solveResult.taskSolution = dr["solutions"].ToString();
                    solveResult.mainTaskId = dr["mainTaskId"].ToString();
                    list.Add(solveResult);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return list;
    }




    public ArrayList getAllThisLayerNeedSolvedCrowTaskInDecomposeResult(string workflow_id,string mainTaskId)
    {
       // int result = 0;
        SqlCommand com = null;
        ArrayList al = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select *  from decomposeResult where simples='{0}' and workflow_id='{1}' and mainTaskId='{2}'", "yes",workflow_id,mainTaskId);

            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                    //输出数据
                    DecomposeResult decomposeResult = new DecomposeResult();
                    decomposeResult.taskName = dr["taskName"].ToString();
                    decomposeResult.taskDescription = dr["taskDescription"].ToString();
                    decomposeResult.taskOrder = dr["taskOrder"].ToString();
                    decomposeResult.workflow_id = dr["workflow_id"].ToString();
                    decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();

                    decomposeResult.vote = dr["vote"].ToString();
                    decomposeResult.simple = dr["simples"].ToString();
                    decomposeResult.mainTaskId = dr["mainTaskId"].ToString();
                    al.Add(decomposeResult);
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return al;
    }

    public int updateDecomposeResultByWokflowIdAndTaskName(string workflow_id,string taskName,string mainTaskId)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
                string sql = string.Format("update decomposeResult set simples= 'yes' where workflow_id='{0}' and taskName='{1}' and mainTaskId='{2}'", workflow_id,taskName,mainTaskId);
                com = new SqlCommand(sql, conn);
              
                 result = com.ExecuteNonQuery();


            //还需要更新crowdTask表里面的数据，创建一个crowdTask的solveTask类型的任务
           // sql = string.Format("update decomposeResult set simples= 'yes' where workflow_id='{0}' and taskName='{1}'", workflow_id, taskName);


        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
          
        }
        return result;
    }
    public int saveSolveResult(CrowdTask crowdTask ,string solution)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("insert into solveResult(taskName,taskDescription,workflow_id,solutions,mainTaskId) values('{0}','{1}','{2}','{3}','{4}')", crowdTask.taskName, crowdTask.taskDescription, crowdTask.taskWorkflowId,solution,crowdTask.mainTaskId);
            com = new SqlCommand(sql, conn);
            int k = com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
          
        }
        return result;
    }
    public SolveResult findSolveResultByWorkflowId(string workflow_id,string mainTaskId)
    {
        SolveResult solveResult = new SolveResult();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from solveResult where workflow_id='{0}' and mainTaskId='{1}'", workflow_id,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                solveResult.taskName = dr["taskName"].ToString();
                solveResult.taskDescription = dr["taskDescription"].ToString();
                solveResult.taskWorkflowId = dr["workflow_id"].ToString();
                solveResult.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                solveResult.taskSolution = dr["solutions"].ToString();
                solveResult.mainTaskId = dr["mainTaskId"].ToString();
            }
          
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return solveResult;
        
    }


    public ArrayList findSolveResultByTaskName(string taskName,string mainTaskId)
    {
        ArrayList al = new ArrayList();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from solveResult where taskName='{0}' and mainTaskId='{1}'", taskName,mainTaskId);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                SolveResult solveResult = new SolveResult();
                solveResult.taskName = dr["taskName"].ToString();
                solveResult.taskDescription = dr["taskDescription"].ToString();
                solveResult.taskWorkflowId = dr["workflow_id"].ToString();
                solveResult.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                solveResult.taskSolution = dr["solutions"].ToString();
                solveResult.mainTaskId = dr["mainTaskId"].ToString();
                al.Add(solveResult);
            }
          
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return al;
        
    }

    public void updateCrowdTaskMainTaskIdByWorkflowId(string workflow_id)
    {
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql1 = string.Format("select * from crowdTask where workflow_id=mainTaskId");
            com = new SqlCommand(sql1,conn);

            SqlDataReader dr = com.ExecuteReader();
            string mainTaskId = null;
            while (dr.Read())
            {
                mainTaskId = dr["workflow_id"].ToString();
            }
            dr.Dispose();
            com.Dispose();
            string sql = string.Format("update crowdTask set mainTaskID='{0}' where workflow_id='{1}'",mainTaskId, workflow_id);
            com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
       
    }
    public void mainTaskSetCrowdTaskMainTaskIdByWorkflowId(string workflow_id)
    {
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("update crowdTask set mainTaskID='{0}' where workflow_id='{1}'",workflow_id,workflow_id);
            com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
    public int saveSolveVoteResult1(string workflow_id, string supportWorklfow_id)
    {

        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("insert into solveVoteResult values('{0}','{1}')", workflow_id, supportWorklfow_id);
            com = new SqlCommand(sql, conn);
            result = com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return result;

    }


    public void updateDecomposeResultVotedByWorkflowId(string workflow_id)
    {
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("update DecomposeResult set vote='{0}' where workflow_id='{1}'", "yes", workflow_id);
            com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }

    }

    public int  getSolveVoteResultBySupportedId(string supportedId)
    {
        SqlCommand com = null;
        int supporedCount = 0;
        try
        {
            conn.Open();
            string sql = string.Format("select count(*) as supporedCount from solveVoteResult where supportWorkflowId='{0}'" ,supportedId);
            com = new SqlCommand(sql, conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                supporedCount = Convert.ToInt32(sdr["supporedCount"].ToString());
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return supporedCount;
    }

    public ArrayList findDecomposeResultByWorkflowIdAndVote(string workflow_id,string mainTaskId)
    {
      
        SqlCommand com = null;
        ArrayList al = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select *  from decomposeResult where workflow_id='{0}' and vote='{1}' and mainTaskId='{2}'", workflow_id, "yes",mainTaskId);

            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                    //输出数据
                    DecomposeResult decomposeResult = new DecomposeResult();
                    decomposeResult.taskName = dr["taskName"].ToString();
                    decomposeResult.taskDescription = dr["taskDescription"].ToString();
                    decomposeResult.taskOrder = dr["taskOrder"].ToString();
                    decomposeResult.workflow_id = dr["workflow_id"].ToString();
                    decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();
                    decomposeResult.vote = dr["vote"].ToString();
                    decomposeResult.simple = dr["simples"].ToString();
                    decomposeResult.mainTaskId = dr["mainTaskId"].ToString();
                    al.Add(decomposeResult);
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return al;
    }

    public string findBestAnswerByWorkflowId(string workflow_id,string mainTaskId)
    {
        SqlCommand com = null;
        string bestAnswer = null;
        try
        {
            conn.Open();
            string sql = string.Format("select *  from solveResult where workflow_id='{0}' and mainTaskId='{1}'", workflow_id,mainTaskId);

            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
             bestAnswer = dr["solutions"].ToString();
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return bestAnswer;
    }

    public int updateSolveResultBestAnswer( string bestAnswerId)
    {
        SqlCommand com = null;
       int result=0;
       try
       {
           conn.Open();
           string sql = string.Format("update solveResult set bestAnswer='{0}' where workflow_id='{1}'", "yes", bestAnswerId);

           com = new SqlCommand(sql, conn);
           result = com.ExecuteNonQuery();
       }

       catch (Exception e)
       {
           throw e;
       }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }

       return result;
    }



   public ArrayList  findallDecomposeResultByVoted(string mainTaskId){
      SqlCommand com = null;
        ArrayList al = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select *  from decomposeResult where vote='{0}' and mainTaskId='{1}'","yes",mainTaskId);

            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                    //输出数据
                    DecomposeResult decomposeResult = new DecomposeResult();
                    decomposeResult.taskName = dr["taskName"].ToString();
                    decomposeResult.taskDescription = dr["taskDescription"].ToString();
                    decomposeResult.taskOrder = dr["taskOrder"].ToString();
                    decomposeResult.workflow_id = dr["workflow_id"].ToString();
                    decomposeResult.parent_workflow_id = dr["parent_workflow_id"].ToString();
                    decomposeResult.vote = dr["vote"].ToString();
                    decomposeResult.simple = dr["simples"].ToString();
                    decomposeResult.mainTaskId = dr["mainTaskId"].ToString();
                    al.Add(decomposeResult);
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return al;

    }


   public ResultNode[] getDivideTree(string workflow_id)
   {

       CrowdTask ct = findCrowdTaskByWorkflowId(workflow_id);

       ArrayList al = new ArrayList();

       al = findCrowdTaskByParentWorkflowIdAndTaskType(ct.taskWorkflowId, TaskType.decomposeTask, ct.mainTaskId);

       int count = findallDecomposeResultByVoted(ct.mainTaskId).Count;
       ResultNode[] rn = new ResultNode[count + 1];

       for (int j = 0; j < rn.Length; j++)
       {
           rn[j] = new ResultNode(null, null);
       }

       rn[0].taskName = ct.taskName;
       rn[0].parentId = rn.Length;

       //根据al里面的每个分解，去decomposeResult里面去寻找vote的东西。

       buildTree(al, rn, 0,0);

       return rn;

   }
    public void buildTree(ArrayList al, ResultNode[] rn,int parentId,int currentId)
    {
        
        for (int i = 0; i < al.Count; i++)
        {
            CrowdTask ctl = al[i] as CrowdTask;
            ArrayList  alist = findDecomposeResultByWorkflowIdAndVote(ctl.taskWorkflowId,ctl.mainTaskId);
            if (alist.Count != 0 )
            {
                int t = currentId;
                //记录下分解内rong
                for (int k=0;k<alist.Count;k++)
	            {
                    t++;
                    DecomposeResult dr = alist[k] as DecomposeResult;
                    rn[t].taskName =dr.taskName;
                    rn[t].parentId = parentId;
                    if (dr.simple == "yes")
                    {
                        rn[t].taskSolution = findSolveResultByTaskNameAndBestAnswer(dr.taskName,dr.mainTaskId).taskSolution;
                    }
                   
	            }
                int r = currentId;
                for (int k = 0; k < alist.Count; k++)
                {
                    DecomposeResult dr = alist[k] as DecomposeResult;
                   
                    if (dr.simple != "yes")
                    {
                        ArrayList klist = findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(dr.workflow_id, dr.taskName, TaskType.decomposeTask, dr.mainTaskId);
                        buildTree(klist, rn,k+currentId+1,currentId+alist.Count);
                    } 
                 
                }
              
            }

        }
    }

    public SolveResult findSolveResultByTaskNameAndBestAnswer(string taskName, string mainTaskId)
    {
        SolveResult sr = new SolveResult();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from solveResult where taskName='{0}' and mainTaskId='{1}' and  bestAnswer='{2}'", taskName,mainTaskId,"yes");
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {

                sr.taskName = dr["taskName"].ToString();
                sr.taskDescription = dr["taskDescription"].ToString();
                sr.taskWorkflowId = dr["workflow_id"].ToString();
                sr.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                sr.taskSolution = dr["solutions"].ToString();
                sr.mainTaskId = dr["mainTaskId"].ToString();
               
            }
          
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return sr;
        
    }

    public int insertDecomposeTree(string taskName,string taskDescription,string taskOrder,string taskSolution,int parentId,string mainTaskId)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("insert into decomposeTree(taskName,taskDescription,taskOrder,taskSolution,parentId,mainTaskWorkflowId) values('{0}','{1}','{2}','{3}','{4}','{5}')", taskName, taskDescription,taskOrder,taskSolution,parentId,mainTaskId);
            com = new SqlCommand(sql, conn);
            result = com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return result;
    }

    public void writeDecomposeTree(string workflow_id)
    {
        CrowdTask ct = findCrowdTaskByWorkflowId(workflow_id);

        ArrayList decomposList = new ArrayList();
        insertDecomposeTree(ct.taskName, ct.taskDescription,null, null, 0, ct.mainTaskId);

        decomposList = findCrowdTaskByParentWorkflowIdAndTaskType(ct.taskWorkflowId, TaskType.decomposeTask, ct.mainTaskId);


        recursionWrite(decomposList);
        
    }

    private void recursionWrite(ArrayList decomposList)
    {
        //遍历decomposeList
        foreach (CrowdTask item in decomposList)
        {
            //根据每一个分解的Id,去查找对应的分解结果
            ArrayList decomposeResultList = findDecomposeResultByWorkflowIdAndVote(item.taskWorkflowId, item.mainTaskId);
            if (decomposeResultList.Count != 0 && decomposeResultList != null)
            {
                //将这个分解结果写入到数据库
                foreach (DecomposeResult dr in decomposeResultList)
                {
                    CrowdTask ct = findCrowdTaskByWorkflowId(item.taskWorkflowId);

                    DecomposeTree dt = findDecomposeTreeByTaskNameAndTaskDescription(ct.taskName, ct.taskDescription, ct.mainTaskId);

                    insertDecomposeTree(dr.taskName, dr.taskDescription,dr.taskOrder, null, dt.id, dr.mainTaskId);

                    if (dr.simple == "yes")
                    {
                        int dtId  = findDecomposeTreeByTaskNameAndTaskDescription(dr.taskName,dr.taskDescription,dr.mainTaskId).id;
                        string taskSolution = findSolveResultByTaskNameAndBestAnswer(dr.taskName, dr.mainTaskId).taskSolution;
                        updateDecomposeTreeSetSolution(taskSolution,dtId);
                    }
                }
                foreach (DecomposeResult dr in decomposeResultList)
                {
                    //遍历当前分解结果list里面的每一个任务，看看是否还有分解，然后再写入到数据库
                    ArrayList subDecomposeList = findCrowdTaskByParentWorkflowIdAndTaskTypeAndTaskName(dr.workflow_id, dr.taskName, TaskType.decomposeTask, dr.mainTaskId);

                    recursionWrite(subDecomposeList);

                }
            }

        }
    }

    public int updateDecomposeTreeSetSolution(String taskSolution,int id)
    {
        int result = 0;
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("update decomposeTree set taskSolution='{0}' where id='{1}'",taskSolution,id);
            com = new SqlCommand(sql, conn);

            result = com.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return result;
    }


    private DecomposeTree findDecomposeTreeByTaskNameAndTaskDescription(string taskName, string taskDescription,string mainTaskId)
    {
        DecomposeTree dt = new DecomposeTree();
        SqlCommand com = null;
        try
        {
            conn.Open();
            string sql = string.Format("select * from decomposeTree where taskName='{0}' and mainTaskWorkflowId='{1}' and  taskDescription='{2}'", taskName, mainTaskId, taskDescription);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dt.id = Convert.ToInt32(dr["id"].ToString());
                dt.taskName = dr["taskName"].ToString();
                dt.taskDescription = dr["taskDescription"].ToString();
                dt.taskOrder = dr["taskOrder"].ToString();
                dt.solution = dr["taskSolution"].ToString();
                dt.parentId = Convert.ToInt32(dr["parentId"].ToString());
                dt.mainTaskId = dr["mainTaskWorkflowId"].ToString();
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        return dt;
        
    }











    public  ArrayList findAllSolveTaskInSolveResultByTaskNameAndTaskDescription(string taskName, string taskDescription, string mainTaskId)
    {
        SqlCommand com = null;
        ArrayList list = new ArrayList();
        try
        {
            conn.Open();
            string sql = string.Format("select *  from solveResult where mainTaskId='{0}' and taskName='{1}' and taskDescription='{2}'", mainTaskId, taskName,taskDescription);
            com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                SolveResult solveResult = new SolveResult();
                solveResult.taskName = dr["taskName"].ToString();

                solveResult.taskDescription = dr["taskDescription"].ToString();
                solveResult.taskWorkflowId = dr["workflow_id"].ToString();
                solveResult.taskParentWorkflowId = dr["parent_workflow_id"].ToString();
                solveResult.taskSolution = dr["solutions"].ToString();
                solveResult.mainTaskId = dr["mainTaskId"].ToString();
                list.Add(solveResult);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            if (com != null)
            {
                com.Dispose();
            }
            if (conn != null)
            {
                conn.Close();
            }

        }
        return list;
    }
}