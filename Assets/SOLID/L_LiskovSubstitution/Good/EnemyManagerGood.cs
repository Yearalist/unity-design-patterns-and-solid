// GOOD EXAMPLE - Manager handles enemies properly


using UnityEngine;

public class EnemyManagerGood : MonoBehaviour
{

    private void Start()
    {
        IEnemy[] allEnemies = FindObjectsOfType<MonoBehaviour>() as IEnemy[];

        // FindObjectsOfType doesn't work directly with interfaces
        // So we find all MonoBehaviours and filter
        MonoBehaviour[] allBehaviours = FindObjectsOfType<MonoBehaviour>();

        foreach (MonoBehaviour behaviour in allBehaviours)
        {
            IEnemy enemy = behaviour as IEnemy;

            if (enemy == null) continue;

            Debug.Log($"[Manager] Found enemy: {enemy.EnemyName}");

            // Only tell movable enemies to move
            if (enemy is IMovableEnemy movableEnemy)
            {
                movableEnemy.Move();
            }
            else
            {
                Debug.Log($"[Manager] {enemy.EnemyName} is stationary, skipping move");
            }

            enemy.Attack();
        }
    }


}
