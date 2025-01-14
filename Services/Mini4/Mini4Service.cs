using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini4
{
    public class Mini4Service : IMini4Service
    {
        public string GreaterThanLessThan (int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1 + " is less than " + num2 + ". \n" + num2 + " is greater than " + num1 + ".";
            } else if (num2 < num1)
            {
                return num2 + " is less than " + num1 + ". \n" + num1 + " is greater than " + num2 + ".";
            } else {
                return num1 + " is equal to " + num2 + ".";
            }
        }
    }
}