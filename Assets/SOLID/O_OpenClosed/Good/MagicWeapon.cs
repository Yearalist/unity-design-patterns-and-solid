// GOOD EXAMPLE - Magic implements IWeapon interface

using UnityEngine;

public class MagicWeapon : MonoBehaviour,IWeapon
{
    
   public string WeaponName => "Magic";
    public void Attack()
    {
        Debug.Log("[Magic] Casting fireball for 20 magic damage!");
        Debug.Log("[Magic] Playing casting animation");
        Debug.Log("[Magic] Spawning fireball projectile");
    }
    public void SpecialAbility()
    {
        Debug.Log("[Magic] Special: Meteor strike!");
    }
    public void GetWeaponInfo()
    {
        Debug.Log("[Magic] Magic weapon, 20 damage, medium range");
    }




}
