namespace MyCarOffice.Api.Model;

public class ResponseModel
{
    public object Data { get; set; }
    public bool IsError { get; set; } = false;
    public string Message { get; set; } = "";
}