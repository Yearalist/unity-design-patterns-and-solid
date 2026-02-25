// BAD EXAMPLE - Trap enemy CANNOT move, but inherits Move() method



using UnityEngine;

public class TrapEnemyBad : EnemyBaseBad
{



    public override void Move()
    {
        // I can't move! I'm a trap! But I'm forced to have this method...
        Debug.LogWarning("[Trap] I CANNOT move! This method should not exist!");
        throw new System.NotImplementedException("Traps cannot move!");
    }

    public override void Attack()
    {
        Debug.Log("[Trap] Player stepped on me! Exploding for 50 damage!");
    }





}
