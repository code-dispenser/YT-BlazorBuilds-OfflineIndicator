namespace BlazorBuilds.Components.OfflineIndicator;

public class OfflineIndicatorService
{
    public event Action<bool> OnConnectionChange = delegate { };

    public bool IsOnline { get; private set; } = true;

    internal void UpdateConnectionStatus(bool isOnline)
    {
        IsOnline = isOnline;
        /*
             * Fire and forget so no blocking handlers 
        */
        foreach (var handler in OnConnectionChange.GetInvocationList())
        {
            _ = Task.Run(() => handler.DynamicInvoke(isOnline));
        }
    }
}
