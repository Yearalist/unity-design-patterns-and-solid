// UniTask can run multiple tasks at the same time (parallel)



using UnityEngine;
using Cysharp.Threading.Tasks;

public class UniTaskParallel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RunParallelTasks().Forget();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            RunSequentialTasks().Forget();
        }
    }

    private async UniTaskVoid RunSequentialTasks()
    {
        Debug.Log("[Sequential] Starting tasks one by one...");
        float startTime = Time.time;

        await LoadWeapons();
        await LoadEnemies();
        await LoadMap();

        float totalTime = Time.time - startTime;
        Debug.Log($"[Sequential] All done! Total time: {totalTime:F1} seconds");
    }

    private async UniTaskVoid RunParallelTasks()
    {
        Debug.Log("[Parallel] Starting ALL tasks at the same time...");
        float startTime = Time.time;

        await UniTask.WhenAll(
            LoadWeapons(),
            LoadEnemies(),
            LoadMap()
        );//Bunlarýn hepsini ayný anda baþlat ve hepsi bitince devam et."

        float totalTime = Time.time - startTime;
        Debug.Log($"[Parallel] All done! Total time: {totalTime:F1} seconds");
    }

    private async UniTask LoadWeapons()
    {
        Debug.Log("[Task] Loading weapons...");
        await UniTask.Delay(2000);
        Debug.Log("[Task] Weapons loaded!");
    }

    private async UniTask LoadEnemies()
    {
        Debug.Log("[Task] Loading enemies...");
        await UniTask.Delay(3000);
        Debug.Log("[Task] Enemies loaded!");
    }

    private async UniTask LoadMap()
    {
        Debug.Log("[Task] Loading map...");
        await UniTask.Delay(2000);
        Debug.Log("[Task] Map loaded!");
    }
}
