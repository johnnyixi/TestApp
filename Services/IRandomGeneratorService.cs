using TestApp.DTO;

namespace TestApp.Services;

public interface IRandomGeneratorService
{
    Task<RandomGeneratorResponse> GenerateAsync();
}
