using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Controllers
{
    [Route("[controller]")]
    public class BirdController: Controller
    {

        [HttpGet]
        public Bird Get()
        {
            return new Bird
            {
                Race = "Rotkehlchen",
                TweetSound = "zwitscher zwitscher",
                Weight = 3
            };
        }

    }
}
