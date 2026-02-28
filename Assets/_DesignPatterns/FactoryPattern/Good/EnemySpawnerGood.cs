// GOOD EXAMPLE - Uses factory to create enemies

using UnityEngine;

public class EnemySpawnerGood : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject goblin = EnemyFactory.CreateEnemy(EnemyType.Goblin);
            Debug.Log("[GOOD] Ordered a Goblin from the factory!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject skeleton = EnemyFactory.CreateEnemy(EnemyType.Skeleton);
            Debug.Log("[GOOD] Ordered a Skeleton from the factory!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject dragon = EnemyFactory.CreateEnemy(EnemyType.Dragon);
            Debug.Log("[GOOD] Ordered a Dragon from the factory!");
        }
    }
}
