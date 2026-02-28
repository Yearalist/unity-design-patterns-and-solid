using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnWave();
        }
    }

    private void SpawnWave()
    {
        Debug.Log("[Wave] === ENEMY WAVE INCOMING! ===");

        for (int i = 0; i < 3; i++)
        {
            EnemyFactory.CreateEnemy(EnemyType.Goblin);
        }

        for (int i = 0; i < 2; i++)
        {
            EnemyFactory.CreateEnemy(EnemyType.Skeleton);
        }

        EnemyFactory.CreateEnemy(EnemyType.Dragon);

        Debug.Log("[Wave] === Wave spawned: 3 Goblins, 2 Skeletons, 1 Dragon ===");
    }
}
