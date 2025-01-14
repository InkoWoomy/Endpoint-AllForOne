using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini2
{
    public class Mini2Service : IMini2Service
    {
        public string AddTwoNumbers(int num1, int num2)
        {
            return num1 + " + " + num2 + " = " + (num1 + num2) + ".";
        }
    }
}