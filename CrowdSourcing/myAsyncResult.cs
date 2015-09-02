using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
    public class myAsyncResult : IAsyncResult
    {
        public object AsyncState
        {
            get;
            set;

        }
        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get;
            set;
        }
        public bool CompletedSynchronously
        {
            get
            {
                return true;
            }
        }
        public bool IsCompleted
        {
            get
            {
                return true;
            }
        }
    }
}
