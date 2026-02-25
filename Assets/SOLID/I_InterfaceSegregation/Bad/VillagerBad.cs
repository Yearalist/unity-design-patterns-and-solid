
// BAD EXAMPLE - Villager is forced to implement Trade, Fight, Patrol

using UnityEngine;

public class VillagerBad : MonoBehaviour, INPCBad
{

    public void Talk()
    {
        Debug.Log("[Villager] Hello traveler! Nice weather today.");
    }

    public void Trade()
    {
        // I'm a villager, I don't trade!
        Debug.LogWarning("[Villager] I don't have anything to trade...");
    }

    public void Fight()
    {
        // I'm a villager, I can't fight!
        Debug.LogWarning("[Villager] I don't know how to fight!");
    }

    public void Patrol()
    {
        // I'm a villager, I don't patrol!
        Debug.LogWarning("[Villager] I'm not a guard, I don't patrol!");
    }

}
