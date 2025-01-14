using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini7A
{
    public class Mini7AService : IMini7AService
    {
        public string ReverseItA (string input)
        {
            int stringLength = input.Length - 1;
            string reversedInput = "";
            for(int i = stringLength; i >= 0; i--)
            {
                
                reversedInput += input[i];
            }
            return reversedInput;
        }
    }
}