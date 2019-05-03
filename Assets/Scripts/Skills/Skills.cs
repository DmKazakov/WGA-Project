using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skills : MonoBehaviour
{
    protected string _name;
    protected int cooldown;
    public int cooldownTimer = 0;
    internal bool isCurrent = false;
    protected int duration;
    protected Unit unit;
    internal double mf;
    public Sprite spriteON;
    public Sprite spriteOFF;


    public abstract int Attack();
    public abstract void Init(Unit unit);

    public void StartCoolDown()
    {
        cooldownTimer = cooldown;
    }


    public void DecreaseCoolDown()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer--;
        }

    }
    public int GetCooldown() {
        return cooldown;
    }

}
