using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
   public  class DecomposeResult
    {
      public string  taskName {get;set;}
	public string taskDescription {get;set;}
	public string taskOrder {get;set;}
    public string workflow_id { get; set; }
    public string parent_workflow_id { get; set; }
    public string vote { get; set; }
    public string simple { get; set; }
    public string mainTaskId { get; set; }
    }
}
