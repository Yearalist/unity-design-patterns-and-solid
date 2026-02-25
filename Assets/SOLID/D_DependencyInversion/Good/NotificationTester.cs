// GOOD EXAMPLE - Test script that demonstrates swapping notification systems


using UnityEngine;

public class NotificationTester : MonoBehaviour
{



    private GameManagerGood gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManagerGood>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameManager.SetNotificationService(new ConsoleNotificationGood());
            gameManager.SendNotification("Switched to Console notifications");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameManager.SetNotificationService(new UINotificationGood());
            gameManager.SendNotification("Switched to UI notifications");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameManager.SetNotificationService(new SoundNotificationGood());
            gameManager.SendNotification("Switched to Sound notifications");
        }
    }
}
