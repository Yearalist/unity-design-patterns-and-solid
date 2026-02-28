// BAD EXAMPLE - Creates and destroys bullets every time

using UnityEngine;

public class BadShooter : MonoBehaviour
{

    private int totalCreated = 0;
    private int totalDestroyed = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBad();
        }
    }

    private void ShootBad()
    {
        GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bullet.transform.position = transform.position;
        bullet.transform.localScale = Vector3.one * 0.3f;
        bullet.AddComponent<BadBullet>();

        totalCreated++;
        Debug.Log($"[BAD] Created bullet #{totalCreated} (Total destroyed: {totalDestroyed})");
    }

    public void BulletDestroyed()
    {
        totalDestroyed++;
    }
}
