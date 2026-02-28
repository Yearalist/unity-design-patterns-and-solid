


using UnityEngine;

public class PooledBullet : MonoBehaviour
{

    private BulletPool pool;
    private float lifeTime = 2f;
    private float timer = 0f;

    public void SetPool(BulletPool bulletPool)//Bu metot, BulletPool tarafýndan çaðrýlýr ve bu PooledBullet'un hangi pool'a ait olduðunu belirtir.
    {
        pool = bulletPool;
    }

    private void OnEnable()//Bu metot, mermi aktif hale geldiðinde çaðrýlýr ve timer'ý sýfýrlar.
    {
        timer = 0f;
    }

    private void Update()//Bu metot, mermi aktif olduðu sürece çalýþýr ve belirli bir süre sonra mermiyi pool'a geri gönderir.
    {
        timer += Time.deltaTime;

        if (timer >= lifeTime)
        {
            pool.ReturnBullet(gameObject);
        }
    }

}
