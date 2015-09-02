using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Runtime;

namespace CrowdSourcing
{

    public sealed class ResumeBookmark : CodeActivity
    { 
        // 定义一个字符串类型的活动输入参数
        public InArgument<Guid> parentWorkflowId { get; set; }
       // public InArgument<WorkflowApplication> parentWorkflowInstance { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 派生并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值

          

           // WorkflowApplicationInstance wa = WorkflowApplication.GetInstance(context.GetValue(parentWorkflowId),,);
           
           // WorkflowInvoker.Invoke
           
           // workflow
          
           
        }
    }
}
