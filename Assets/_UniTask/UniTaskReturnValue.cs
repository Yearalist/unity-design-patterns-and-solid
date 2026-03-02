using UnityEngine;
using Cysharp.Threading.Tasks;

public class UniTaskReturnValue : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            LoadPlayerData().Forget();
        }
    }

    private async UniTaskVoid LoadPlayerData()
    {
        Debug.Log("[Return Value] Loading player data...");

        int playerScore = await FetchScore();
        Debug.Log($"[Return Value] Player score loaded: {playerScore}");

        string playerName = await FetchName();
        Debug.Log($"[Return Value] Player name loaded: {playerName}");

        float playTime = await FetchPlayTime();
        Debug.Log($"[Return Value] Play time loaded: {playTime} hours");

        Debug.Log($"[Return Value] All data: {playerName} | Score: {playerScore} | Time: {playTime}h");
    }

    private async UniTask<int> FetchScore()//Bu metod bekledikten sonra bir int döndürüyor.
    {
        // Simulating a server request that takes time
        await UniTask.Delay(500);
        return 9500;
    }

    private async UniTask<string> FetchName()
    {
        await UniTask.Delay(500);
        return "DragonSlayer42";
    }

    private async UniTask<float> FetchPlayTime()
    {
        await UniTask.Delay(500);
        return 127.5f;
    }

}
