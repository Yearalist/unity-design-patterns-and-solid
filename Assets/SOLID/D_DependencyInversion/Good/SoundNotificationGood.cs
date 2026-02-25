using UnityEngine;

public class SoundNotificationGood : INotificationService
{
    public void Send(string message)
    {
        Debug.Log($"[SOUND] *ding* Playing notification sound for: {message}");
    }
}
