// CHOP TREE STATE - Character is chopping the tree

using UnityEngine;

public class ChopTreeState : IState
{
    private WoodcutterCharacter character;
    private float timeChopping = 0f;

    public ChopTreeState(WoodcutterCharacter character)
    {
        this.character = character;
    }

    public void Enter()
    {
        timeChopping = 0f;
        Debug.Log("[State: CHOP TREE] Started chopping the tree! *chop chop chop*");
    }

    public void Update()
    {
        timeChopping += Time.deltaTime;//Ne kadar süredir kesiyoruz sayýyor

        if (timeChopping >= character.chopTime)
        {
            Debug.Log("[State: CHOP TREE] Tree chopped down! Wood is ready.");
            character.stateMachine.ChangeState(new CollectWoodState(character));
        }
    }

    public void Exit()
    {
        Debug.Log("[State: CHOP TREE] Done chopping!");
    }
}
