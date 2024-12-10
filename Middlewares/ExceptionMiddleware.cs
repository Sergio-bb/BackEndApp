using BackEndApp.Domain.Responses;
using System.Net;
using System.Text.Json;

namespace BackEndApp.Middlewares;

public class ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                // Intentar ejecutar la solicitud
                await next(httpContext);
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, manejarla aquí
                logger.LogError($"Ocurrió un error: {ex.Message}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var response = new BaseResponse<string>(
                success: false,
                message: "Se produjo un error en el servidor.",
                data: null
            );

            // Registrar el detalle de la excepción en los logs
            logger.LogError(exception, "Excepción no controlada");

            // Serializar la respuesta a JSON
            var result = JsonSerializer.Serialize(response);

            // Devolver la respuesta al cliente
            return context.Response.WriteAsync(result);
        }
    
}
