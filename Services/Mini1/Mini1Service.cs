using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini1
{
    public class Mini1Service : IMini1Service
    {
        public string SayHello(string input)
        {
            return "Hello, " + input + ". Nice to meet you.";
        }
    }
}