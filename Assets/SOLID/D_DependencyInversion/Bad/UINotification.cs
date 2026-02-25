// BAD EXAMPLE - A specific notification system that shows on screen


using UnityEngine;

public class UINotification 
{
    public void DisplayOnScreen(string message)
    {
        Debug.Log($"[UI POPUP] === {message} ===");
    }
}
