// BAD EXAMPLE - God Class
// This class violates Single Responsibility Principle
// It handles movement, health, attack, and upgrade logic all in one place

using UnityEngine;

public class CharacterGodClass : MonoBehaviour
{
    // Movement
    private float moveSpeed = 5f;
    private Vector3 targetPosition;

    // Health
    private int maxHealth = 100;
    private int currentHealth;
    private bool isDead;

    // Attack
    private int attackDamage = 10;
    private float attackRange = 2f;
    private float attackCooldown = 1f;
    private float lastAttackTime;

    // Upgrade
    private int level = 1;
    private int experience = 0;
    private int experienceToNextLevel = 100;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        HandleMovement();
        HandleAttack();
        HandleUpgrade();
    }

    // --- Movement Logic ---
    private void HandleMovement()
    {
        if (isDead) return;

        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Input.mousePosition;
        }

        transform.position = Vector3.MoveTowards(
            transform.position, targetPosition, moveSpeed * Time.deltaTime);

        Debug.Log($"[Movement] Position: {transform.position}");
    }

    // --- Health Logic ---
    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        Debug.Log($"[Health] Took {damage} damage. Current: {currentHealth}/{maxHealth}");

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
    }

    private void Die()
    {
        isDead = true;
        Debug.Log("[Health] Character died!");
    }

    // --- Attack Logic ---
    private void HandleAttack()
    {
        if (isDead) return;

        if (Input.GetKeyDown(KeyCode.Space))
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
    }

    // --- Upgrade Logic ---
    private void HandleUpgrade()
    {
        if (experience >= experienceToNextLevel)
        {
            level++;
            experience -= experienceToNextLevel;
            experienceToNextLevel = level * 100;

            maxHealth += 10;
            attackDamage += 5;
            moveSpeed += 0.5f;

            Debug.Log($"[Upgrade] Level up! Now level {level}");
            Debug.Log($"[Upgrade] Stats - HP:{maxHealth} ATK:{attackDamage} SPD:{moveSpeed}");
        }
    }

    public void GainExperience(int amount)
    {
        experience += amount;
        Debug.Log($"[Upgrade] Gained {amount} XP. Total: {experience}/{experienceToNextLevel}");
    }
}