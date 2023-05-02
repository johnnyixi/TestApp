using TestApp.DTO;

namespace TestApp.Services;

public interface IImportantService
{
    Task<ImportantResponse> DoImportantStuffAsync();
}
