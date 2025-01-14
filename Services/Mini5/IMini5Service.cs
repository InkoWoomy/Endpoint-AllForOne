using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini5
{
    public interface IMini5Service
    {
        public string MadLibs (string verb1, string verb2, string verb3, string place, string personName, string animal, string adjective, string clothingItem, string noun1, string noun2);
    }
}