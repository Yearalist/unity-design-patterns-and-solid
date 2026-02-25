// GOOD EXAMPLE - Merchant implements ITalkable and ITradeable

using UnityEngine;

public class MerchantGood : MonoBehaviour, ITalkable, ITradeable
{

    public void Talk()
    {
        Debug.Log("[Merchant] Welcome! Take a look at my goods.");
    }

    public void Trade()
    {
        Debug.Log("[Merchant] Here are my items for sale!");
    }
}
