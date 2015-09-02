using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
    public  class SolveResult
    {
        public string taskName { get; set; }
        public string taskDescription { get; set; }

      
        public string taskWorkflowId { get; set; }
        public string taskParentWorkflowId { get; set; }

        public string taskSolution { get; set; }


        public string mainTaskId { get; set; }
    }
}
