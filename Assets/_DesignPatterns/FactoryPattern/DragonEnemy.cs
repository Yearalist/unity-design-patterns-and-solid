using UnityEngine;

public class DragonEnemy : MonoBehaviour
{
    public string enemyName;
    public int health;
    public int damage;
    public float speed;

    private void Start()
    {
        Debug.Log($"[{enemyName}] Spawned! HP:{health} DMG:{damage} SPD:{speed}");
    }

    public void GetInfo()
    {
        Debug.Log($"[{enemyName}] HP:{health} DMG:{damage} SPD:{speed}");
    }
}
