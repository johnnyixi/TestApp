using System.Diagnostics;
using TestApp.DTO;

namespace TestApp.Services;

public class ImportantService : IImportantService
{
    private const int SimulatedLatencyDuration = 3000;

    private readonly ICorrelationService _correlationService;

    public ImportantService(ICorrelationService correlationService)
    {
        _correlationService = correlationService;
    }

    public async Task<ImportantResponse> DoImportantStuffAsync()
    {
        var stopwatch = new Stopwatch();

        stopwatch.Start();

        await GetInfoFromSourceA();
        await GetInfoFromSourceB();
        await GetInfoFromSourceC();

        stopwatch.Stop();

        return await Task.FromResult(new ImportantResponse(_correlationService.GetCorrelationId(), stopwatch.ElapsedMilliseconds.ToString()));
    }

    private static Task GetInfoFromSourceA()
    {
        return Task.Delay(SimulatedLatencyDuration);
    }

    private static Task GetInfoFromSourceB()
    {
        return Task.Delay(SimulatedLatencyDuration);
    }

    private static Task GetInfoFromSourceC()
    {
        return Task.Delay(SimulatedLatencyDuration);
    }
}
