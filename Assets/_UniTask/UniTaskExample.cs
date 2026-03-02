using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;

public class UniTaskExample : MonoBehaviour
{

    private CancellationTokenSource cancellationTokenSource;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            cancellationTokenSource = new CancellationTokenSource();
            DoTasksWithUniTask(cancellationTokenSource.Token).Forget();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                Debug.Log("[UniTask] Tasks cancelled!");
            }
        }
    }

    private async UniTaskVoid DoTasksWithUniTask(CancellationToken token)
    {
        Debug.Log("[UniTask] Starting tasks...");

        try
        {
            Debug.Log("[UniTask] Task 1: Loading resources...");
            await UniTask.Delay(1000, cancellationToken: token);//1000 milisaniye (1 saniye) bekle
            Debug.Log("[UniTask] Task 1: Done!");

            Debug.Log("[UniTask] Task 2: Processing data...");
            await UniTask.Delay(2000, cancellationToken: token);
            Debug.Log("[UniTask] Task 2: Done!");

            Debug.Log("[UniTask] Task 3: Saving progress...");
            await UniTask.Delay(1000, cancellationToken: token);
            Debug.Log("[UniTask] Task 3: Done!");

            Debug.Log("[UniTask] All tasks completed!");
        }
        catch (System.OperationCanceledException)
        {
            Debug.Log("[UniTask] Tasks were cancelled by user!");
        }
    }

    private void OnDestroy()
    {
        cancellationTokenSource?.Cancel();
        cancellationTokenSource?.Dispose();
    }
}
