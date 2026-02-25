// GOOD EXAMPLE - Console notification that follows the INotificationService standard

using UnityEngine;

public class ConsoleNotificationGood : INotificationService
{

    public void Send(string message)
    {
        Debug.Log($"[CONSOLE] {message}");
    }


}
