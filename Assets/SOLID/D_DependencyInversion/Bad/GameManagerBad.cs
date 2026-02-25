// BAD EXAMPLE - GameManager directly depends on SPECIFIC notification classes

using UnityEngine;

public class GameManagerBad : MonoBehaviour
{
    private ConsoleNotification consoleNotification = new ConsoleNotification();
    private UINotification uiNotification = new UINotification();
    private bool useUI = false;

    private void Start()
    {
        SendNotification("Game Started!");
        SendNotification("Player entered the dungeon");
        SendNotification("Boss appeared!");
    }

    public void SendNotification(string message)
    {
        if (useUI)
        {
            uiNotification.DisplayOnScreen(message);
        }
        else
        {
            consoleNotification.SendConsoleMessage(message);
        }
    }
}
