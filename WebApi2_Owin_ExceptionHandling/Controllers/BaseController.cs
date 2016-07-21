using System.Net.Http;
using System.Web.Http;
using WebApi2_Owin_ExceptionHandling.HttpResponseExceptions;

namespace WebApi2_Owin_ExceptionHandling.Controllers
{
    public class BaseController : ApiController
    {
        #region HttpResponseException

        protected CustomHttpCreatedResponse Created(HttpRequestMessage request, string message)
        {
            return new CustomHttpCreatedResponse(request, message);
        }

        #endregion
    }
}