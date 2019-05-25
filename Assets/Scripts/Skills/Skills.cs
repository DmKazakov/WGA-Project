using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Skills : MonoBehaviour
{
    public string _name;
    protected int cooldown;
    public int cooldownTimer = 0;
    public int cooldownTimerBASE = 0;
    internal bool isCurrent = false;

    public int duration;
    public int durationTimer;
    

    protected Unit unit;
    internal double mf;
    public Sprite spriteON;
    public Sprite spriteOFF;


    public abstract int[] Attack();
    public abstract int[] Effect();
    public abstract void Init(Unit unit);

    public void StartCoolDown()
    {
        cooldownTimer = cooldownTimerBASE + cooldown;
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
