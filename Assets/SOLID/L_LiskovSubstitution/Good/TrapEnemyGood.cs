// GOOD EXAMPLE - Trap ONLY implements IEnemy, NOT IMovableEnemy

using UnityEngine;

public class TrapEnemyGood : MonoBehaviour,IEnemy
{
    public string EnemyName => "Trap";//Hareket edemez o yüzden sadece IEnemy'yi implement ediyoruz

    public void Attack()
    {
        Debug.Log("[Trap] Player stepped on me! Exploding for 50 damage!");
    }

    public void GetInfo()
    {
        Debug.Log("[Trap] Stationary explosive trap, high damage");
    }

}
