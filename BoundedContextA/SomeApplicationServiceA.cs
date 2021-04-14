using System;
using System.Collections.Generic;
using System.Text;

namespace BoundedContextA
{
    public class SomeApplicationServiceA
    {
        public string DoSomething()
        {
            return "Action triggered by context B executed in context A, here is your result.";
        }
    }
}
