using System.Web.Http;
using WebApi2_Owin_ExceptionHandling.ExceptionFilter;

namespace WebApi2_Owin_ExceptionHandling.Controllers
{
    [RoutePrefix("exceptionfiltercontroller")]
    public class ExceptionFilterController : BaseController
    {
        [ItemNotFoundExceptionFilter]
        [Route("{id:int}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            throw ItemNotFound($"Cannot find item : {id}");
        }
    }
}
