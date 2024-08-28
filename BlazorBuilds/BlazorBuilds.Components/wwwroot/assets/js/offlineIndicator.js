let _isOnlineHandlerRegistered = false;
function registerOnlineNotification(blazorCallBackRef, callBackName) {
    if (_isOnlineHandlerRegistered === true)
        return navigator.onLine;
    window.addEventListener("online", _ => blazorCallBackRef.invokeMethodAsync(callBackName, navigator.onLine));
    window.addEventListener("offline", _ => blazorCallBackRef.invokeMethodAsync(callBackName, navigator.onLine));
    _isOnlineHandlerRegistered = true;
    return navigator.onLine;
}
export { registerOnlineNotification };
//# sourceMappingURL=offlineIndicator.js.map