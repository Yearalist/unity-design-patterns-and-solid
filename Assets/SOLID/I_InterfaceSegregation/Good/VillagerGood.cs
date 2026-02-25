
// GOOD EXAMPLE - Villager only implements ITalkable
using UnityEngine;

public class VillagerGood : MonoBehaviour,ITalkable
{
    public void Talk()
    {
        Debug.Log("[Villager] Hello traveler! Nice weather today.");
    }
}
