// State Machine - Manages which state is currently active

using UnityEngine;

public class StateMachine 
{
    private IState currentState;// þuanki durumumuz

    public IState CurrentState => currentState;// þuanki durumumuzu dýþarýya açmak için

    public void ChangeState(IState newState)// yeni bir duruma geçmek istediðimizde çaðýracaðýmýz fonksiyon
    {
        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;
        currentState.Enter();
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }
}
