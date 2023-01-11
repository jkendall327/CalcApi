namespace CalcApi.Data;

public class RequestLog
{
    public required int Id { get; set; }

    public required DateTime Recieved { get; set; }

    public required string Details { get; set; }
}