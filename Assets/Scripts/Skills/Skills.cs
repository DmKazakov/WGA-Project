using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Skills : MonoBehaviour
{
    public string _name;
    public string description;

    internal int cooldown;
    public int cooldownTimer = 0;
    public int cooldownTimerBASE = 0;
    internal bool isCurrent = false;

    public int duration;
    public int durationTimer;


    protected Unit unit;
    internal double mf;
    public Sprite spriteON;
    public Sprite spriteOFF;

    protected string trigger;
    protected string triggerEffect;

    public abstract int[] Attack();
    public abstract int[] Effect();
    public abstract void Init(Unit unit);

    public GameObject particle;

    public AudioClip activeSound;
    public AudioClip effectSound;

    public virtual void EffectAnimation(GameObject gobj)
    {
        if (particle != null)
        {
            Transform transform = gobj.transform;
            print("создаем анимацию эффекта");
            GameObject anim = Instantiate(particle, transform.position, Quaternion.identity);
            anim.transform.SetParent(transform);
        }
        else { print("нет партикла"); }
    }

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
   
    public int GetCooldown()
    {
        return cooldown;
    }
    public string GetTrigger()
    {
        return trigger;
    }
    public string GetTriggerEffect()
    {
        return triggerEffect;
    }
}
