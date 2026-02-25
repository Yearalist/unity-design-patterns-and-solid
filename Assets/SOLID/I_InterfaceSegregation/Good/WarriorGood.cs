// GOOD EXAMPLE - Warrior implements ITalkable, IFightable, and IPatrollable

using UnityEngine;

public class WarriorGood : MonoBehaviour, ITalkable, IFightable, IPatrollable
{
    public void Talk()
    {
        Debug.Log("[Warrior] Stand back citizen, I'll protect you.");
    }

    public void Fight()
    {
        Debug.Log("[Warrior] Charging into battle! Taking 30 damage swing!");
    }

    public void Patrol()
    {
        Debug.Log("[Warrior] Patrolling the area, keeping watch.");
    }
}
