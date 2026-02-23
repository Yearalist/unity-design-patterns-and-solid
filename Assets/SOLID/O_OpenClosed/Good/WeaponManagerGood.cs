// GOOD EXAMPLE - This manager works with ANY weapon through the IWeapon interface

using UnityEngine;

public class WeaponManagerGood : MonoBehaviour
{

    private IWeapon currentWeapon;

    private void Start()
    {
        currentWeapon = GetComponent<IWeapon>();

        if (currentWeapon != null)
        {
            Debug.Log($"[WeaponManager] Equipped: {currentWeapon.WeaponName}");
        }
    }

    private void Update()
    {
        if (currentWeapon == null) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentWeapon.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentWeapon.SpecialAbility();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            currentWeapon.GetWeaponInfo();
        }
    }

    public void EquipWeapon(IWeapon newWeapon)
    {
        currentWeapon = newWeapon;
        Debug.Log($"[WeaponManager] Switched to: {currentWeapon.WeaponName}");
    }

}
