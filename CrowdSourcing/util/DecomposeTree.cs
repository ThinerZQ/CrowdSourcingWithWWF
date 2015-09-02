using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
    public class DecomposeTree
    {
        public int id{get;set;}
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public string taskOrder { get; set; }
        public string solution { get; set; }
        public int parentId { get; set; }
        public string mainTaskId { get; set; }
    }
}
