
// GOOD EXAMPLE - GameManager depends on the INTERFACE, not specific classes

using UnityEngine;

public class GameManagerGood : MonoBehaviour
{
    private INotificationService notificationService;

    private void Start()
    {
        // "Plug in" whichever notification system you want
        // Just change this one line to swap the entire system!
        notificationService = new ConsoleNotificationGood();
        // notificationService = new UINotificationGood();
        // notificationService = new SoundNotificationGood();

        SendNotification("Game Started!");
        SendNotification("Player entered the dungeon");
        SendNotification("Boss appeared!");
    }

    // This method can also receive the service from outside (Dependency Injection)
    public void SetNotificationService(INotificationService service)
    {
        notificationService = service;
        Debug.Log("[GameManager] Notification system changed!");
    }

    public void SendNotification(string message)
    {
        notificationService.Send(message);
    }

}
