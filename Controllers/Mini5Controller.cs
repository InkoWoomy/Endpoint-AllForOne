using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini5;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini5Controller : Controller
    {
        private readonly IMini5Service _logger;

        public Mini5Controller(IMini5Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("MiniChallenge5-MadLibs/{verb1}/{verb2}/{verb3}/{place}/{personName}/{animal}/{adjective}/{clothingItem}/{noun1}/{noun2}")]
        public string MadLibs (string verb1, string verb2, string verb3, string place, string personName, string animal, string adjective, string clothingItem, string noun1, string noun2)
        {
            return _logger.MadLibs(verb1, verb2, verb3, place, personName, animal, adjective, clothingItem, noun1, noun2);
        }
    }
}