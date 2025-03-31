using UnityEngine;

public class Mammal : Animal
{
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }

    public override void Eat(int energyGained)
    {
        Debug.Log("chomp chomp eating with my mouth");
        base.Eat(energyGained);
    }

    public virtual void GiveBirth()
    {
        Debug.Log("Giving birth to a mammal");
    }
}
