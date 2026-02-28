using UnityEngine;

public static class EnemyFactory
{
    public static GameObject CreateEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Goblin:
                return CreateGoblin();

            case EnemyType.Skeleton:
                return CreateSkeleton();

            case EnemyType.Dragon:
                return CreateDragon();

            default:
                Debug.LogError($"[Factory] Unknown enemy type: {enemyType}");
                return null;
        }
    }

    private static GameObject CreateGoblin()
    {
        GameObject enemy = new GameObject("Goblin");
        GoblinEnemy script = enemy.AddComponent<GoblinEnemy>();
        script.enemyName = "Goblin";
        script.health = 50;
        script.damage = 5;
        script.speed = 4f;

        Debug.Log("[Factory] Produced a Goblin");
        return enemy;
    }

    private static GameObject CreateSkeleton()
    {
        GameObject enemy = new GameObject("Skeleton");
        SkeletonEnemy script = enemy.AddComponent<SkeletonEnemy>();
        script.enemyName = "Skeleton";
        script.health = 80;
        script.damage = 10;
        script.speed = 2.5f;

        Debug.Log("[Factory] Produced a Skeleton");
        return enemy;
    }

    private static GameObject CreateDragon()
    {
        GameObject enemy = new GameObject("Dragon");
        DragonEnemy script = enemy.AddComponent<DragonEnemy>();
        script.enemyName = "Dragon";
        script.health = 200;
        script.damage = 30;
        script.speed = 6f;

        Debug.Log("[Factory] Produced a Dragon");
        return enemy;
    }
}