namespace TestApp.DTO;

public class GenerateDataResponse
{
    public Guid CorrelationId { get; }

    public RandomGeneratorResponse RandomGeneratorResponse { get; }

    public ImportantResponse ImportantResponse { get; }

    public GenerateDataResponse(Guid correlationId, RandomGeneratorResponse randomGeneratorResponse, ImportantResponse importantResponse)
    {
        CorrelationId = correlationId;
        RandomGeneratorResponse = randomGeneratorResponse;
        ImportantResponse = importantResponse;
    }
}