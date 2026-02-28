// IDLE STATE - Character is standing still, waiting

using UnityEngine;

public class IdleState : IState
{
    private WoodcutterCharacter character;

    public IdleState(WoodcutterCharacter character)// constructor to receive the character reference
    {
        this.character = character;
    }

    public void Enter()
    {
        Debug.Log("[State: IDLE] Standing around... Press SPACE to go chop wood.");
        Debug.Log($"[State: IDLE] Wood in base: {character.woodInBase}");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.stateMachine.ChangeState(new MoveToTreeState(character));// SPACE tuþuna basýldýðýnda MoveToTreeState durumuna geçiþ yapýyoruz
        }
    }

    public void Exit()
    {
        Debug.Log("[State: IDLE] Alright, let's go to work!");
    }
}
