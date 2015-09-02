using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
    public class ResultNode
    {
        public string taskName= null;
        public string taskSolution = null;

        public int parentId = 0;
        public ResultNode(string taskName, string taskSolution)
        {
            this.taskName = taskName;
            this.taskSolution = taskSolution;
            parentId = 0;
            
        }
        
    }
}
