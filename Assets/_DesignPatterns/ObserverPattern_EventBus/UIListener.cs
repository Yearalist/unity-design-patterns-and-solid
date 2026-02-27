//Ayný olay, farklý tepki. Ses çalýyor.

using UnityEngine;

public class UIListener : MonoBehaviour
{

    private int killCount = 0;

    private void OnEnable()
    {
        EventBus.Subscribe("EnemyDied", OnEnemyDied);
        EventBus.Subscribe("AllEnemiesDead", OnAllEnemiesDead);
    }

    private void OnDisable()
    {
        EventBus.Unsubscribe("EnemyDied", OnEnemyDied);
        EventBus.Unsubscribe("AllEnemiesDead", OnAllEnemiesDead);
    }

    private void OnEnemyDied()
    {
        killCount++;
        Debug.Log($"[UI] === ENEMY ELIMINATED! Kill count: {killCount} ===");
    }

    private void OnAllEnemiesDead()
    {
        Debug.Log("[UI] *** VICTORY! ALL ENEMIES DEFEATED! ***");
    }

}
