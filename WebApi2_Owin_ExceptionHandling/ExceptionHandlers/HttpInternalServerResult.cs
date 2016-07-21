using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi2_Owin_ExceptionHandling.ExceptionHandlers
{
    public class HttpInternalServerResult : IHttpActionResult
    {
        private HttpRequestMessage _request;
        private string _message;

        public HttpInternalServerResult(HttpRequestMessage request, string message)
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
            return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(_message),
                RequestMessage = _request,
                ReasonPhrase = "Unknown Error"
            };
        }
    }
}