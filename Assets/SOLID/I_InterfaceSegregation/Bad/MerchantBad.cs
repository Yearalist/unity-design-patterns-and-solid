// BAD EXAMPLE - Merchant is forced to implement Fight and Patrol

using UnityEngine;

public class MerchantBad : MonoBehaviour, INPCBad
{

    public void Talk()
    {
        Debug.Log("[Merchant] Welcome! Take a look at my goods.");
    }

    public void Trade()
    {
        Debug.Log("[Merchant] Here are my items for sale!");
    }

    public void Fight()
    {
        // I'm a merchant, I sell things, I don't fight!
        Debug.LogWarning("[Merchant] I'm a merchant, not a warrior!");
    }

    public void Patrol()
    {
        // I'm a merchant, I stay at my shop!
        Debug.LogWarning("[Merchant] I need to stay at my shop!");
    }

}
