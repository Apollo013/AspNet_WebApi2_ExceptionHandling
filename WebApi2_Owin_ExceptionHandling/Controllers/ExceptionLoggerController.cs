using System;
using System.Web.Http;

namespace WebApi2_Owin_ExceptionHandling.Controllers
{
    [RoutePrefix("exceptionlogger")]
    public class ExceptionLoggerController : BaseController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            // The following will throw a 401 which is specifically caught and handled by our GlobalExceptionHandler
            throw new UnauthorizedAccessException();

            // The following will throw an exception which is loosely caught and handled by our GlobalExceptionHandler
            //throw new NullReferenceException("Object Null");

        }
    }
}
