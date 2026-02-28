// RETURN TO BASE STATE - Character is walking back to base with wood

using UnityEngine;

public class ReturnToBaseState : IState
{
    private WoodcutterCharacter character;
    private float distanceToBase = 10f;
    private float distanceTraveled = 0f;

    public ReturnToBaseState(WoodcutterCharacter character)
    {
        this.character = character;
    }

    public void Enter()
    {
        distanceTraveled = 0f;
        Debug.Log($"[State: RETURN] Heading back to base with {character.woodCarrying} wood...");
    }

    public void Update()
    {
        distanceTraveled += character.moveSpeed * Time.deltaTime;

        if (distanceTraveled >= distanceToBase)
        {
            character.woodInBase += character.woodCarrying;//Taþýdýðýn odunlarý base'e ekle
            character.totalWoodCollected += character.woodCarrying;
            Debug.Log($"[State: RETURN] Delivered {character.woodCarrying} wood to base!");
            Debug.Log($"[State: RETURN] Total wood in base: {character.woodInBase}");
            character.woodCarrying = 0;//Ellerin boþaldý
            character.stateMachine.ChangeState(new IdleState(character));//Döngü tamamlandý, tekrar Idle'a dön.
        }
    }

    public void Exit()
    {
        Debug.Log("[State: RETURN] Back at base! Time to rest.");
    }
}
