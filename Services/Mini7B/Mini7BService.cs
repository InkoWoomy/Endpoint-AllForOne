using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini7B
{
    public class Mini7BService : IMini7BService
    {
        public string ReverseItB (string input)
        {
            int parsedInput;
            int intReversed = 0;
            if (int.TryParse(input, out parsedInput))
            {
                Convert.ToInt32(parsedInput);
                if (parsedInput < 0)
                {
                    parsedInput = parsedInput * -1;
                } 
                    while (parsedInput > 0) 
                    { 
                        intReversed = intReversed * 10 + parsedInput % 10;
                        parsedInput /= 10;
                    }
                if (parsedInput < 0)
                {
                    intReversed = intReversed * -1;
                } 
                return "The reverse of " + input + " is " + intReversed + "!";

            } else {
                return "Not an integer!";
            }
            
        }
    }
}