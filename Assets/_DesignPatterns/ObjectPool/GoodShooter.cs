using UnityEngine;

public class GoodShooter : MonoBehaviour
{
    private BulletPool bulletPool;

    private void Start()//Bu metot, sahne baþladýðýnda çaðrýlýr ve BulletPool'u bulur.
    {
        bulletPool = FindObjectOfType<BulletPool>();
    }

    private void Update()//Bu metot, her frame çaðrýlýr ve boþluk tuþuna basýldýðýnda ShootGood() metodunu çaðýrýr.
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootGood();
        }
    }

    private void ShootGood()//Bu metot, BulletPool'dan bir mermi alýr, onu atýþ noktasýna yerleþtirir ve ateþlendiðini loglar.
    {
        GameObject bullet = bulletPool.GetBullet();
        bullet.transform.position = transform.position;
        Debug.Log("[GOOD] Shot fired using pooled bullet!");
    }
}
