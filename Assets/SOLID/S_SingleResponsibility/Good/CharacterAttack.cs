// GOOD EXAMPLE - Single Responsibility: Attack Only

using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    private int attackDamage = 10;
    private float attackCooldown = 1f;
    private float lastAttackTime;

    private CharacterHealth characterHealth;

    private void Awake()
    {
        characterHealth = GetComponent<CharacterHealth>();
    }

    private void Update()
    {
        if (characterHealth != null && characterHealth.IsDead) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryAttack();
        }
    }

    private void TryAttack()
    {
        if (Time.time - lastAttackTime >= attackCooldown)
        {
            lastAttackTime = Time.time;
            Debug.Log($"[Attack] Attacked for {attackDamage} damage!");
        }
        else
        {
            Debug.Log("[Attack] Attack on cooldown!");
        }
    }

    public void IncreaseDamage(int amount)
    {
        attackDamage += amount;
    }
}



 