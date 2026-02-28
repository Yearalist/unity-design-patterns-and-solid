// BAD EXAMPLE - Enemy creation logic is scattered and repeated

using UnityEngine;

public class EnemySpawnerBad : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Creating a Goblin - all details hardcoded right here
            GameObject goblin = new GameObject("Goblin");
            GoblinEnemy goblinScript = goblin.AddComponent<GoblinEnemy>();
            goblinScript.health = 50;
            goblinScript.damage = 5;
            goblinScript.speed = 4f;
            goblinScript.enemyName = "Goblin";
            Debug.Log("[BAD] Manually created Goblin with hardcoded values");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Creating a Skeleton - same manual process
            GameObject skeleton = new GameObject("Skeleton");
            SkeletonEnemy skeletonScript = skeleton.AddComponent<SkeletonEnemy>();
            skeletonScript.health = 80;
            skeletonScript.damage = 10;
            skeletonScript.speed = 2.5f;
            skeletonScript.enemyName = "Skeleton";
            Debug.Log("[BAD] Manually created Skeleton with hardcoded values");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Creating a Dragon - same manual process again
            GameObject dragon = new GameObject("Dragon");
            DragonEnemy dragonScript = dragon.AddComponent<DragonEnemy>();
            dragonScript.health = 200;
            dragonScript.damage = 30;
            dragonScript.speed = 6f;
            dragonScript.enemyName = "Dragon";
            Debug.Log("[BAD] Manually created Dragon with hardcoded values");
        }
    }

}
