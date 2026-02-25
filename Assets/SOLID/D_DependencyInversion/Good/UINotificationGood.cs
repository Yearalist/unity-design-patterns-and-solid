
// GOOD EXAMPLE - UI notification that follows the same standard

using UnityEngine;

public class UINotificationGood : INotificationService
{

    public void Send(string message)
    {
        Debug.Log($"[UI POPUP] === {message} ===");
    }
}
