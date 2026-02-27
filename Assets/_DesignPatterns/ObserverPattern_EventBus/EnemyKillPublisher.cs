using UnityEngine;

public class EnemyKillPublisher : MonoBehaviour
{

    private int enemiesAlive = 5;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (enemiesAlive > 0)
            {
                enemiesAlive--;
                Debug.Log($"[Publisher] Enemy killed! Remaining: {enemiesAlive}");
                EventBus.Publish("EnemyDied");//Radyo istasyonuna haber gönder: "Düþman öldü!" Kim dinliyorsa harekete geçsin.

                if (enemiesAlive <= 0)
                {
                    Debug.Log("[Publisher] All enemies eliminated!");
                    EventBus.Publish("AllEnemiesDead");
                }
            }
            else
            {
                Debug.Log("[Publisher] No enemies left to kill!");
            }
        }
    }

}
