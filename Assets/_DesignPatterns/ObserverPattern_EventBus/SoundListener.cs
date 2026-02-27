//Ayný olay, farklý tepki. Ses çalýyor.

using UnityEngine;

public class SoundListener : MonoBehaviour
{
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
        Debug.Log("[Sound] *SLASH* Playing enemy death sound effect");
    }

    private void OnAllEnemiesDead()
    {
        Debug.Log("[Sound] *FANFARE* Playing victory music!");
    }

}
