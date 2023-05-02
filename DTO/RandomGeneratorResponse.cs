namespace TestApp.DTO;

public class RandomGeneratorResponse
{
    public Guid CorrelationId { get; }
    public string TimeInMilliseconds { get; }

    public RandomGeneratorResponse(Guid correlationId, string timeInMilliseconds)
    {
        CorrelationId = correlationId;
        TimeInMilliseconds = timeInMilliseconds;
    }
}
