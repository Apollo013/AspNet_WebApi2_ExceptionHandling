using NLog;
using System;
using System.Web.Http.ExceptionHandling;

namespace WebApi2_Owin_ExceptionHandling.ExceptionLoggers
{
    public class GlobalExceptionLogger : ExceptionLogger
    {
        private static Logger logger = LogManager.GetLogger("logfile");

        public override void Log(ExceptionLoggerContext context)
        {
            if (context.Exception is UnauthorizedAccessException)
            {
                logger.Warn(context.Exception.Message);
            }
            else
            {
                logger.Info(context.Exception.Message);
            }
        }
    }
}