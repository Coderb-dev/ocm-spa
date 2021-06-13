using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ocm_spa.Services
{
    public interface IInterop
    {
        Task InitializeBootstrap(string selector);
    }
    public class InteropService : IInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public InteropService(IJSRuntime jsRuntime) => _jsRuntime = jsRuntime;

        public async Task InitializeBootstrap(string selector) => await _jsRuntime.InvokeVoidAsync("interop.initializeBootstrap", selector);

    }
}