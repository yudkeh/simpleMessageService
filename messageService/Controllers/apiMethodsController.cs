using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace messageService.Controllers
{
    [Produces("application/json")]
    [Route("api/message")]
    public class apiMethodsController : Controller
    {
        [HttpGet("{message}")]
        public string Get(string message)
        {
            char[] messageChars = message.ToCharArray();
            Array.Reverse(messageChars);
            JValue reversedMessage = new JValue(new string(messageChars));

            return reversedMessage.ToString();
        }
    }
}