using System.Web.Http;

namespace _4EmptyWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new[] { "A", "B" });
        }
    }
}
