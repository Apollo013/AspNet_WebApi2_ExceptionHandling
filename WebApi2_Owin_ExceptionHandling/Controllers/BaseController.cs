using System.Net.Http;
using System.Web.Http;
using WebApi2_Owin_ExceptionHandling.ExceptionFilter;
using WebApi2_Owin_ExceptionHandling.HttpResponseExceptions;

namespace WebApi2_Owin_ExceptionHandling.Controllers
{
    public class BaseController : ApiController
    {

        protected HttpCreatedResult Created(HttpRequestMessage request, string message)
        {
            return new HttpCreatedResult(request, message);
        }

        protected ItemNotFoundException ItemNotFound(string message)
        {
            return new ItemNotFoundException(message);
        }
    }
}