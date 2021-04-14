using System;
using System.Collections.Generic;
using System.Text;

namespace BoundedContextB
{
    public class SomeApplicationServiceB
    {
        public string DoSomething()
        {
            return "Action triggered by context A executed in context B, here is your result.";
        }
    }
}
