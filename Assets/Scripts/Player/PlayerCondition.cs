using System;
using UnityEngine;

public interface IDamagable
{
    void TakePhysicalDamage(int damage);
}

public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UIConditions uiConditions;
    Condition health { get { return uiConditions.health; } }
    Condition hunger { get { return uiConditions.hunger; } }
    Condition stamina { get { return uiConditions.stamina; } }
    Condition mana { get { return uiConditions.mana; } }

    public float noHungerHealthDecay;

    public event Action onTakeDamage;

    void Update()
    {
        hunger.Subtract(hunger.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        if (hunger.curValue == 0f)
        {
            health.Subtract(noHungerHealthDecay * Time.deltaTime);
        }

        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Eat(float amount)
    {
        hunger.Add(amount);
    }
    public void Die()
    {
        Debug.Log("죽었다");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage?.Invoke();
    }

    public void UseSkill(float amount)
    {
        mana.Subtract(amount);
    }

    public void UseManaItem(float amount)
    {
        mana.Add(amount);
    }
}
