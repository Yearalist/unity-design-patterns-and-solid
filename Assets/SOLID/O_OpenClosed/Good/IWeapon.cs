// GOOD EXAMPLE - Interface defines the "standard" every weapon must follow


public interface IWeapon 
{

    string WeaponName { get; }
    void Attack();
    void SpecialAbility();
    void GetWeaponInfo();

}
