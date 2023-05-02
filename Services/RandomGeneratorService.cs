using System.Diagnostics;
using System.Security.Cryptography;
using TestApp.DTO;

namespace TestApp.Services;

public class RandomGeneratorService : IRandomGeneratorService
{
    const int Min = 1;
    const int Max = 1000000;
    const int Target = 400000;
    readonly byte[] randomBytes = new byte[4];

    private readonly ICorrelationService _correlationService;

    public RandomGeneratorService(ICorrelationService correlationService)
    {
        _correlationService = correlationService;
    }

    public Task<RandomGeneratorResponse> GenerateAsync()
    {
        var correlationId = _correlationService.GetCorrelationId();

        var drawnNumbers = new List<int>();

        var stopwatch = new Stopwatch();

        stopwatch.Start();

        for (var i = 0; i < Target; i++)
        {
            bool numberAdded = false;

            while (!numberAdded)
            {
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomBytes);
                }

                var randomNumber = Math.Abs(BitConverter.ToInt32(randomBytes, 0) % (Max - Min + 1)) + Min;

                if (!drawnNumbers.Contains(randomNumber))
                {
                    drawnNumbers.Add(randomNumber);
                    numberAdded = true;
                }
            }
        }

        stopwatch.Stop();

        return Task.FromResult(new RandomGeneratorResponse(correlationId, stopwatch.ElapsedMilliseconds.ToString()));
    }
}
