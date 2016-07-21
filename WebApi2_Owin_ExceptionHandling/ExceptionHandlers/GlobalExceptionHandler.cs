using System;
using System.Web.Http.ExceptionHandling;

namespace WebApi2_Owin_ExceptionHandling.ExceptionHandlers
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            if (context.Exception is UnauthorizedAccessException)
            {
                context.Result = new HttpNotAuthorizedResult(context.Request, "Access Denied: You are not permitted to perform this action.");
            }
            else
            {
                context.Result = new HttpInternalServerResult(context.Request, context.Exception.Message);
            }
        }
    }
}