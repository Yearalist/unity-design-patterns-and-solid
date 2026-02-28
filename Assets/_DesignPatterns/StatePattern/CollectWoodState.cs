// COLLECT WOOD STATE - Character is picking up the wood

using UnityEngine;

public class CollectWoodState : IState
{

    private WoodcutterCharacter character;
    private float timeCollecting = 0f;

    public CollectWoodState(WoodcutterCharacter character)
    {
        this.character = character;
    }

    public void Enter()
    {
        timeCollecting = 0f;
        Debug.Log("[State: COLLECT] Picking up wood from the ground...");
    }

    public void Update()
    {
        timeCollecting += Time.deltaTime;

        if (timeCollecting >= character.collectTime)
        {
            character.woodCarrying = 3;//Toplama bitince "3 odun aldým, eve dönüyorum" diyor.
            Debug.Log($"[State: COLLECT] Picked up {character.woodCarrying} wood! Heading back to base.");
            character.stateMachine.ChangeState(new ReturnToBaseState(character));
        }
    }

    public void Exit()
    {
        Debug.Log("[State: COLLECT] All wood collected, let's go home!");
    }

}
