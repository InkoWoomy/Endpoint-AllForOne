using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_AllForOne.Services.Mini5
{
    public class Mini5Service : IMini5Service
    {
        public string MadLibs (string verb1, string verb2, string verb3, string place, string personName, string animal, string adjective, string clothingItem, string noun1, string noun2)
            {

            return "Today, I decided to " + verb1 + " at the " + place + " because my best friend, " + personName + ", told me it would be fun. When I got there, I saw a giant " + animal + " wearing a " + adjective + " " + clothingItem + ". It was " + verb3 + " around and trying to " + verb2 + " a " + noun1 + ". I couldn’t believe my eyes, so I took a quick " + noun2 + " and ran home!";
        }
        
    }
}