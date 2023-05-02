using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestApp.DTO;
using TestApp.Services;

namespace TestApp.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController : ControllerBase
{
    private readonly ICorrelationService _correlationService;
    private readonly IRandomGeneratorService _randomGeneratorService;
    private readonly IImportantService _importantService;

    public DataController(ICorrelationService correlationService, IRandomGeneratorService randomGeneratorService, IImportantService importantService)
    {
        _correlationService = correlationService;
        _randomGeneratorService = randomGeneratorService;
        _importantService = importantService;
    }

    [HttpGet]
    public async Task<IActionResult> GenerateData()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        var correlationId = _correlationService.GetCorrelationId();
        var generatedResponse = await _randomGeneratorService.GenerateAsync();
        var importantResponse = await _importantService.DoImportantStuffAsync();

        stopwatch.Stop();

        var response = new GenerateDataResponse(correlationId, generatedResponse, importantResponse);

        return Ok(response);
    }
}
