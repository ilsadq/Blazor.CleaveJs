using Microsoft.JSInterop;

namespace Blazor.CleaveJs;

public class CleaveJsProvider : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _module;

    public CleaveJsProvider(IJSRuntime js)
    {
        _module = new(
            js.InvokeAsync<IJSObjectReference>("import", "./_content/Blazor.CleaveJs/index.js").AsTask()
        );
    }
    
    public async Task SetInput(string id, CleaveSettingsModel settings)
    {
        var js = await _module.Value;
        await js.InvokeVoidAsync("setInput", id, settings);
    }

    public async Task SetInput(string id, CleaveSettingsModel settings, DotNetObjectReference<CleaveWrapper> dotObj)
    {
        var js = await _module.Value;
        await js.InvokeVoidAsync("setInputWithCallback", id, settings, dotObj);
    }

    public async ValueTask DisposeAsync()
    {
        if (!_module.IsValueCreated) return;
        _module.Value.Dispose();
    }
}