namespace TestApp.DTO;

public class ImportantResponse
{
    public Guid CorrelationId { get; }
    public string TimeInMillisecond { get; }

    public ImportantResponse(Guid correlationId, string timeInMillisecond)
    {
        CorrelationId = correlationId;
        TimeInMillisecond = timeInMillisecond;
    }
}
