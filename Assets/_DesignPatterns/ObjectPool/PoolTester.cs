using UnityEngine;

public class PoolTester : MonoBehaviour
{
    private BadShooter badShooter;
    private GoodShooter goodShooter;

    private void Start()
    {
        badShooter = FindObjectOfType<BadShooter>();
        goodShooter = FindObjectOfType<GoodShooter>();

        Debug.Log("=== OBJECT POOL TEST ===");
        Debug.Log("Press B to shoot with BAD method (Instantiate/Destroy)");
        Debug.Log("Press G to shoot with GOOD method (Object Pool)");
        Debug.Log("Watch the console to see the difference!");
        Debug.Log("========================");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (badShooter != null)
            {
                badShooter.SendMessage("ShootBad");
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (goodShooter != null)
            {
                goodShooter.SendMessage("ShootGood");
            }
        }
    }
}
