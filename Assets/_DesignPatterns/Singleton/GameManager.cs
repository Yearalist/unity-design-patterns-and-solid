// Singleton Pattern - Only ONE GameManager can exist in the entire game
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("[GameManager] Instance not found!");
            }
            return _instance;
        }
    }

    private int score = 0;
    private bool isGamePaused = false;

    public int Score => score;
    public bool IsGamePaused => isGamePaused;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Debug.LogWarning("[GameManager] Duplicate found! Destroying this one.");
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("[GameManager] Singleton initialized successfully!");
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log($"[GameManager] Score: {score}");
    }

    public void TogglePause()
    {
        isGamePaused = !isGamePaused;
        Debug.Log($"[GameManager] Game {(isGamePaused ? "PAUSED" : "RESUMED")}");
    }

    public void ResetGame()
    {
        score = 0;
        isGamePaused = false;
        Debug.Log("[GameManager] Game reset!");
    }
}