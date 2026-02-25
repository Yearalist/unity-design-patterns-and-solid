// BAD EXAMPLE - Base class assumes ALL enemies can move and attack




using UnityEngine;


public class EnemyBaseBad : MonoBehaviour
{
    
    public virtual void Move()
    {

        Debug.Log("[Enemy] Moving towards player");

    }

    public virtual void Attack()
    {
        Debug.Log("[Enemy] Attacking player");
    }

}
