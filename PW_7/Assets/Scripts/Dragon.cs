using UnityEngine;

public class Dragon : Person
{
    public override void TakeDamage(int damageValue)
    {
        Debug.Log($" I, the mighty dragon, have lost: {damageValue} hitpoints from a hunter's shot.");
    }
}
