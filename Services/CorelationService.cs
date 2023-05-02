namespace TestApp.Services;

public class CorrelationService : ICorrelationService
{

    private readonly Guid CorrelationId;

    public CorrelationService()
    {
        CorrelationId = Guid.NewGuid();
    }


    public Guid GetCorrelationId() => CorrelationId;
}
