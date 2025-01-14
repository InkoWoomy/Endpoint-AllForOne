using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini3
{
    public class Mini3Service : IMini3Service
    {
        public string AskingQuestions (string name, int time)
        {
            return "So your name is " + name + " and you woke up at a time of " + time  + "AM.";   
        }
    }
}