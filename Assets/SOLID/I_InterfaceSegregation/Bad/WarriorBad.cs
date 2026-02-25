// BAD EXAMPLE - Warrior is forced to implement Trade

using UnityEngine;

public class WarriorBad : MonoBehaviour, INPCBad
{
    public void Talk()
    {
        Debug.Log("[Warrior] Stand back citizen, I'll protect you.");
    }

    public void Trade()
    {
        // I'm a warrior, I don't trade!
        Debug.LogWarning("[Warrior] I have nothing to sell!");
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
