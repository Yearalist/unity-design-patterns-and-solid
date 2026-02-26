using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("=== SINGLETON TEST ===");
        Debug.Log($"[Test] GameManager instance ID: {GameManager._instance.GetInstanceID()}");

        // Try to create a second GameManager - it will destroy itself!
        GameObject duplicate = new GameObject("GameManager_Duplicate");
        duplicate.AddComponent<GameManager>();

        Debug.Log($"[Test] After duplicate attempt, instance ID: {GameManager._instance.GetInstanceID()}");
        Debug.Log("[Test] If IDs are the same, Singleton is working correctly!");
        Debug.Log("=== TEST COMPLETE ===");
    }
}
