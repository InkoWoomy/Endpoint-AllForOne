using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini3;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini3Controller : Controller
    {
        private readonly IMini3Service _logger;

        public Mini3Controller(IMini3Service  logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("MiniChallenge3-AskingQuestions/{name}/{time}")]
        public string AskingQuestions(string name, int time)
        {
            return _logger.AskingQuestions(name, time);
        }
    }
}