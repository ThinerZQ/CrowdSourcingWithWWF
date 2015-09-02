using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace CrowdSourcing
{

    public sealed class getDividedTaskNumber : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public OutArgument<int> divideTaskNumber { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 派生并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
            int number = int.Parse(Console.ReadLine());
            context.SetValue(divideTaskNumber, number);
        }
    }
}
