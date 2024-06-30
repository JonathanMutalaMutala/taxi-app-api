using System.Net;
using taxi_app_api.Exceptions;
using taxi_app_api.Utilities;

namespace taxi_app_api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                // Essayer de passer au HttpContext suivant si on a un Exception on va aller dans le catch 
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                // Methode permettant de gerer l'excption 
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        public async  Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            var errorDetails = new ErrorDetails(); 

            if (ex is NotFoundException)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                errorDetails = new ErrorDetails()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Message = ex.Message
                }; 
            }
            await httpContext.Response.WriteAsJsonAsync(errorDetails);
        }
    }
}
