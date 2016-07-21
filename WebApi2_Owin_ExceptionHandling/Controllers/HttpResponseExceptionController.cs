using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2_Owin_ExceptionHandling.Controllers
{
    [RoutePrefix("api/httpresponseexceptions")]
    public class HttpResponseExceptionController : BaseController
    {
        /// <summary>
        /// Returns a 201 (Created) status
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("customcreatedresponse/{name}")]
        [HttpPost]
        public IHttpActionResult CustomCreatedResponse(string name)
        {
            return Created(Request, $"{name} was successfully created using a custom 'IHttpActionResult' implementation");
        }

        /// <summary>
        /// Returns a 200 status
        /// </summary>
        /// <returns></returns>
        [Route("ok")]
        [HttpGet]
        public IHttpActionResult BuiltinOkResponse()
        {
            return Ok("Shortcut 'OK' Response Method");
        }

        /// <summary>
        /// Returns a 404 status
        /// </summary>
        /// <returns></returns>
        [Route("notfound")]
        [HttpGet]
        public IHttpActionResult BuiltinNotFoundResponse()
        {
            return NotFound();
        }


        /// <summary>
        /// Returns a 204 status
        /// </summary>
        /// <returns></returns>
        [Route("nocontent")]
        [HttpGet]
        public HttpResponseMessage NoContent()
        {
            return Request.CreateResponse(HttpStatusCode.NoContent, "This is a 'No Content' response created with 'Request.CreateResponse'");
        }

        /// <summary>
        /// Returns a 400 (BadRequest) status if id > 100, 200 (OK) if < 100
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("checkid/{id}")]
        [HttpGet]
        public IHttpActionResult CheckId(int id)
        {
            if (id > 100)
            {
                var message = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("We cannot use IDs greater than 100.")
                };
                throw new HttpResponseException(message);
            }
            return Ok(id);
        }


    }
}
