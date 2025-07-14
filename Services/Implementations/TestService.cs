
using TemplateApi.Services.Interfaces;

namespace TemplateApi.Services.Implementations
{
    public class TestService : ITestService
    {
        public TestService()
        {
        }

        public async Task<string> GetModels()
        {
            return "It is ok :)";
        }
    }
}