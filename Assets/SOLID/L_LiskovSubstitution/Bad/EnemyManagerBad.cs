// BAD EXAMPLE - This manager expects ALL enemies to move and attack


using UnityEngine;

public class EnemyManagerBad : MonoBehaviour
{
    private EnemyBaseBad[] allEnemies;

    private void Start()
    {
        allEnemies = FindObjectsOfType<EnemyBaseBad>();

        Debug.Log($"[Manager] Found {allEnemies.Length} enemies. Commanding all to move and attack!");

        foreach (EnemyBaseBad enemy in allEnemies)
        {
            enemy.Move();    // TrapEnemy will CRASH here!
            enemy.Attack();
        }
    }
}
