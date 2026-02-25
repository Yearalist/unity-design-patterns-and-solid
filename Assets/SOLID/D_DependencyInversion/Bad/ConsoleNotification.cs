// BAD EXAMPLE - A specific notification system that logs to console


using UnityEngine;

public class ConsoleNotification 
{

    public void SendConsoleMessage(string message)
    {
        Debug.Log($"[CONSOLE] {message}");
    }

}
