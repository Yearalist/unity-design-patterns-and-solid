// BAD EXAMPLE - This bullet destroys itself after lifetime

using UnityEngine;

public class BadBullet : MonoBehaviour
{
    private float speed = 20f;
    private float lifeTime = 2f;
    private float timer = 0f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= lifeTime)
        {
            BadShooter shooter = FindObjectOfType<BadShooter>();
            if (shooter != null)
            {
                shooter.BulletDestroyed();
            }

            Debug.Log("[BAD] Bullet destroyed! (Memory freed, but this is expensive)");
            Destroy(gameObject);
        }
    }
}
