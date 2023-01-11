namespace CalcApi.Data;

public class RequestLog
{
    public int Id { get; set; }

    public required DateTime RecievedUtc { get; set; }

    public required string Details { get; set; }
}