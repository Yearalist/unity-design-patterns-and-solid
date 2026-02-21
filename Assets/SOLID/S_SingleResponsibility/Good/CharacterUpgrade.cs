// GOOD EXAMPLE - Single Responsibility: Upgrade Only

using UnityEngine;

public class CharacterUpgrade : MonoBehaviour
{
    private int level = 1;
    private int experience = 0;
    private int experienceToNextLevel = 100;

    private CharacterMovement characterMovement;
    private CharacterHealth characterHealth;
    private CharacterAttack characterAttack;


    private void Awake()
    {
        characterMovement = GetComponent<CharacterMovement>();
        characterHealth = GetComponent<CharacterHealth>();
        characterAttack = GetComponent<CharacterAttack>();
    }

    private void CheckLevelUp()
    {
        if (experience >= experienceToNextLevel)
        {
            level++;
            experience -= experienceToNextLevel;
            experienceToNextLevel = level * 100;

            characterHealth.IncreaseMaxHealth(10);
            characterAttack.IncreaseDamage(5);
            characterMovement.SetMoveSpeed(5f + (level - 1) * 0.5f);

            Debug.Log($"[Upgrade] Level up! Now level {level}");
        }
    }



}
