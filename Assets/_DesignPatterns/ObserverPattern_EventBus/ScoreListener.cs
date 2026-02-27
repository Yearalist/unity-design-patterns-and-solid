using UnityEngine;

public class ScoreListener : MonoBehaviour
{
    private int score = 0;

    private void OnEnable()//GameObject aktif olduðunda çalýþýr. Burada radyoyu açýp frekansa ayarlanýyoruz. "EnemyDied olayýný dinlemeye baþla."
    {
        EventBus.Subscribe("EnemyDied", OnEnemyDied);
        EventBus.Subscribe("AllEnemiesDead", OnAllEnemiesDead);
    }

    private void OnDisable()//GameObject deaktif olduðunda çalýþýr. Radyoyu kapatýyoruz. Bu çok önemli — abonelikten çýkmayý unutursan, nesne yok edildikten sonra bile çaðrýlmaya çalýþýr ve hata alýrsýn. Taksici taksiden indi ama radyo hala onu arýyor gibi olur.
    {
        EventBus.Unsubscribe("EnemyDied", OnEnemyDied);
        EventBus.Unsubscribe("AllEnemiesDead", OnAllEnemiesDead);
    }

    private void OnEnemyDied()
    {
        score += 100;
        Debug.Log($"[Score] +100 points! Total: {score}");
    }

    private void OnAllEnemiesDead()
    {
        score += 500;
        Debug.Log($"[Score] BONUS +500 points! Total: {score}");
    }
}
