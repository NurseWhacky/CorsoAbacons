using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : Controller
    {
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
