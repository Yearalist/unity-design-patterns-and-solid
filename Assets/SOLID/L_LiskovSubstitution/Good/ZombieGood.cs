// GOOD EXAMPLE - Zombie implements BOTH IEnemy and IMovableEnemy

using UnityEngine;

public class ZombieGood : MonoBehaviour,IEnemy, IMovableEnemy
{

    public string EnemyName => "Zombie";

    public void Move()
    {
        Debug.Log("[Zombie] Shambling slowly towards player");
    }

    public void Attack()
    {
        Debug.Log("[Zombie] Biting player for 10 damage!");
    }

    public void GetInfo()
    {
        Debug.Log("[Zombie] Slow undead enemy, melee attacker");
    }

}
