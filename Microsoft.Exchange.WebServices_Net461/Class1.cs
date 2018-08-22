using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Exchange.WebServices_Net461
{
    public class Class1
    {
        public static async System.Threading.Tasks.Task AsyncTest()
        {
            await System.Threading.Tasks.Task.CompletedTask;
        }


        public static void Test()
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            { }
        }


    }
}
