using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi2_Owin_ExceptionHandling.HttpResponseExceptions
{
    public class CustomHttpCreatedResponse : IHttpActionResult
    {
        private HttpRequestMessage _request;
        private string _message;

        public CustomHttpCreatedResponse(HttpRequestMessage request, string message)
        {
            _request = request;
            _message = message;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(ExecuteResult());
        }

        public Task<IHttpActionResult> ExecuteAsync()
        {
            return Task.FromResult<IHttpActionResult>(this);
        }

        public HttpResponseMessage ExecuteResult()
        {
            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent(_message),
                RequestMessage = _request
            };
        }
    }
}