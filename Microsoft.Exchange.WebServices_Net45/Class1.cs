﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Exchange.WebServices_Net45
{
    public class Class1
    {

        public static async System.Threading.Tasks.Task AsyncTest()
        {
            await System.Threading.Tasks.Task.FromResult(0);
        }

        public static void Test()
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            { }
        }

    }
}
