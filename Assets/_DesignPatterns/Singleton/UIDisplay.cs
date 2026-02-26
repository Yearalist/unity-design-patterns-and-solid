// UI script that also accesses the same GameManager Singleton

using UnityEngine;

public class UIDisplay : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log($"[UI] Current Score: {GameManager._instance.Score}");
            Debug.Log($"[UI] Is Paused: {GameManager._instance.IsGamePaused}");
        }
    }
}
