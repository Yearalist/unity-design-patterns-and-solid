
// GOOD EXAMPLE - Single Responsibility: Health Only
using UnityEngine;
using System;

public class CharacterHealth : MonoBehaviour
{

    private int maxHealth = 100;
    private int currentHealth;
    private bool isDead;

    public event Action OnDeath;
    public event Action<int, int> OnHealthChanged;

    public bool IsDead => isDead;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        Debug.Log($"[Health] Took {damage} damage. Current: {currentHealth}/{maxHealth}");
        OnHealthChanged?.Invoke(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (isDead) return;

        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        Debug.Log($"[Health] Healed {amount}. Current: {currentHealth}/{maxHealth}");
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    public void IncreaseMaxHealth(int amount)
    {
        maxHealth += amount;
    }
    private void Die()
    {
        isDead = true;
        Debug.Log("[Health] Character died!");
        OnDeath?.Invoke();
    }


}
