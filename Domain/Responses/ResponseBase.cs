namespace BackEndApp.Domain.Responses;

public class BaseResponse<T>(bool success, string message, T data)
{
    public bool Success { get; set; } = success;
    public string Message { get; set; } = message;
    public T Data { get; set; } = data;
}
