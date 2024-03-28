using UnityEngine;

public class Player : Person
{
    private int experience = 0;
    public int Experience  
    {
        get {return experience;} 
        private set {}
    }

    public override void ShowStat()
    {
        Debug.Log($"Your name: {Name}\nYour experience: {Experience}");
    }

    public override void TakeDamage(int damageValue)
    {
        Debug.Log($"My name is {Name} \nAfter hitting with force: {damageValue} I have: {Health - damageValue} ");
    }
}
