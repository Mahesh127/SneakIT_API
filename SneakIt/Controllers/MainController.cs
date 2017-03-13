using System.Web;
using System.Web.Http;

namespace SneakIt.Controllers
{
    public class MainController
    {
        [Route("api/tiles")]
        public string GetTiles()
        {
            return "TEST";
        }
    }
}