using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }

        [HttpGet]
        [Route("time")]
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }

        [HttpGet]
        [Route("hash/{value}/{value2}")]
        public string GetHashCode(string value, string value2)
        {
            return $"{value.GetHashCode().ToString()} ... {value2.GetHashCode().ToString()}";
        }
    }
}
