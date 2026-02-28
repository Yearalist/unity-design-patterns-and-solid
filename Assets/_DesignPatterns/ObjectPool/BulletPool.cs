// GOOD EXAMPLE - Object Pool that pre-creates bullets and reuses them

using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{

    private Queue<GameObject> pool = new Queue<GameObject>();//Tepsiler rafta sýrayla dizilir.
    private int poolSize = 20;
    private int totalReused = 0;

    private void Start()
    {
        FillPool();
    }

    private void FillPool()//Raftaki tepsileri doldurur.
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = CreateBullet();
            bullet.SetActive(false);
            pool.Enqueue(bullet);
        }
        Debug.Log($"[POOL] Created {poolSize} bullets in advance. Pool is ready!");
    }

    private GameObject CreateBullet()//Yeni bir tepsi oluþturur.
    {
        GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bullet.transform.localScale = Vector3.one * 0.3f;
        bullet.AddComponent<Bullet>();

        PooledBullet pooledBullet = bullet.AddComponent<PooledBullet>();
        pooledBullet.SetPool(this);

        return bullet;
    }

    public GameObject GetBullet()//Raftan bir tepsi alýr, eðer rafta yoksa yeni bir tepsi oluþturur.
    {
        if (pool.Count > 0)
        {
            GameObject bullet = pool.Dequeue();
            bullet.SetActive(true);
            totalReused++;
            Debug.Log($"[POOL] Bullet taken from pool. Reused {totalReused} times. Remaining in pool: {pool.Count}");
            return bullet;
        }
        else
        {
            Debug.Log("[POOL] Pool empty! Creating a new bullet.");
            GameObject bullet = CreateBullet();
            bullet.SetActive(true);
            return bullet;
        }
    }

    public void ReturnBullet(GameObject bullet)//Tepsiyi rafta geri býrakýr.
    {
        bullet.SetActive(false);
        pool.Enqueue(bullet);
        Debug.Log($"[POOL] Bullet returned to pool. Available: {pool.Count}");
    }

}
