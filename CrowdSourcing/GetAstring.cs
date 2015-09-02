using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace CrowdSourcing
{

    public sealed class GetAstring : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public OutArgument<string> inputstring { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 派生并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
             string it = System.Console.ReadLine();

            System.Console.WriteLine("你输入的是："+it);

            if (it == null)
            {
                it = "something wrong";
            }

            context.SetValue(inputstring,it);
        }
    }
}
