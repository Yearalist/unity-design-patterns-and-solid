// Player script that uses GameManager Singleton

using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Kill enemy, gain score
            GameManager._instance.AddScore(10);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Pause/unpause game
            GameManager._instance.TogglePause();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reset game
            GameManager._instance.ResetGame();
        }
    }
}
