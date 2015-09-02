using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcing
{
    public class SetBookmark : NativeActivity
    {
        public InArgument<string> bookmarkName { get; set; }
        public OutArgument<Object> returnObjectValue { get; set; }

        protected override bool CanInduceIdle
        {
            get
            { return true; }
        }

  


        protected override void Execute(NativeActivityContext context)
        {
            string bookmark = context.GetValue(bookmarkName);
            context.CreateBookmark(bookmark, new BookmarkCallback(bookmarkCallback));
            System.Console.WriteLine("创建bookmark:{0}", bookmark);
        }


        void bookmarkCallback(NativeActivityContext context, Bookmark bookmark, object obj)
        {

            context.SetValue(returnObjectValue, obj);

        }
    }
}
