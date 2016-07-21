using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi2_Owin_ExceptionHandling.ExceptionHandlers
{
    public class HttpNotAuthorizedResult : IHttpActionResult
    {
        private HttpRequestMessage _request;
        private string _message;

        public HttpNotAuthorizedResult(HttpRequestMessage request, string message)
        {
            _request = request;
            _message = message;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(CreateResponse());
        }

        public HttpResponseMessage CreateResponse()
        {
            return new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent(_message),
                RequestMessage = _request,
                ReasonPhrase = ""
            };
        }
    }
}