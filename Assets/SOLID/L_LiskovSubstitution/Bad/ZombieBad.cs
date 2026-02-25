// BAD EXAMPLE - Zombie works fine, it can move and attack


using UnityEngine;

public class ZombieBad : EnemyBaseBad
{

    public override void Move()
    {
        Debug.Log("[Zombie] Shambling slowly towards player");
    }

    public override void Attack()
    {
        Debug.Log("[Zombie] Biting player for 10 damage!");
    }


}
