// State Pattern - Interface that every state must follow

using UnityEngine;

public interface IState 
{

    void Enter();
    void Update();
    void Exit();

}
