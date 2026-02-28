// MOVE TO TREE STATE - Character is walking towards the tree

using UnityEngine;

public class MoveToTreeState : IState
{

    private WoodcutterCharacter character;
    private float distanceToTree = 10f;
    private float distanceTraveled = 0f;

    public MoveToTreeState(WoodcutterCharacter character)
    {
        this.character = character;
    }

    public void Enter()
    {
        distanceTraveled = 0f;
        Debug.Log("[State: MOVE TO TREE] Walking towards the tree...");
    }

    public void Update()
    {
        distanceTraveled += character.moveSpeed * Time.deltaTime;

        if (distanceTraveled >= distanceToTree)
        {
            Debug.Log("[State: MOVE TO TREE] Arrived at the tree!");
            character.stateMachine.ChangeState(new ChopTreeState(character));
        }
    }

    public void Exit()
    {
        Debug.Log("[State: MOVE TO TREE] Reached the tree, time to chop!");
    }
}
