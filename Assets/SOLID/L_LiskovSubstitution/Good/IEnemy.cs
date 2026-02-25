// GOOD EXAMPLE - Base interface that ALL enemies share

using UnityEngine;

public interface IEnemy 
{

    string EnemyName { get; }
    void Attack();
    void GetInfo();

}
