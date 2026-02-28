// The character that uses State Machine to manage its behavior

using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class WoodcutterCharacter : MonoBehaviour
{

    public StateMachine stateMachine;// durum makinemiz

    public float moveSpeed = 3f;
    public float chopTime = 2f;
    public float collectTime = 1f;
    public int woodCarrying = 0;
    public int woodInBase = 0;
    public int totalWoodCollected = 0;

    private void Start()
    {
        stateMachine = new StateMachine();
        stateMachine.ChangeState(new IdleState(this));// baþlangýç durumumuz IdleState olacak
    }

    private void Update()
    {
        stateMachine.Update();
    }

}
