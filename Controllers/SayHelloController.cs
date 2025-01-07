using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CombineMini1.Services;

namespace CombineMini1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CombineMini1 : Controller
    {
        private readonly ISayHello _sayHello;

        public CombineMini1(ISayHello sayHello)
        {
            _sayHello = sayHello;
        }

        //Combine Mini Challenge 1
        [HttpGet] 
        [Route("MiniChallenge1/{nameInput}")]
        public string SayingHello(string nameInput)
        {
            return _sayHello.SayingHello(nameInput);
        }
    }
}

