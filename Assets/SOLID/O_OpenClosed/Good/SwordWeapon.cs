// GOOD EXAMPLE - Sword implements IWeapon interface

using UnityEngine;

public class SwordWeapon : MonoBehaviour, IWeapon
{
   public string WeaponName => "Sword";

    public void Attack()
    {
        Debug.Log("[Sword] Swinging sword for 20 melee damage!");
        Debug.Log("[Sword] Playing slash animation");
        Debug.Log("[Sword] Applying close range hit detection");
    }

    public void SpecialAbility()
    {
        Debug.Log("[Sword] Special: Whirlwind slash!");
    }

    public void GetWeaponInfo()
    {
        Debug.Log("[Sword] Melee weapon, 20 damage, short range");
    }


}
