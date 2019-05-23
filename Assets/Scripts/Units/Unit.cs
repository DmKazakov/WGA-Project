using UnityEngine;
using UnityEngine.UI;

using System.Collections.Generic;


public abstract class Unit : MonoBehaviour
{
    public int level;

    public string nameGame = "";

    public int freeStatPoints;
    public int strength;
    public int agility;
    public int vitality;
    private int[] basicStats = new int[3];

    public int hitPoint; //мах
    public int currentHitPoint;
    public float criticalChance;
    public float criticalMF;
    public int criticalDMG;
    public float dodge;
    public int armor;
    public int initiative;

    public int minDMG;
    public int maxDMG;

   

    public GameObject[] currentSkills = new GameObject[3];
    public GameObject[] activeSkills = new GameObject[3];

    public List<Skills> effectSkills = new List<Skills>();

    public Sprite headIcon;



    public void Recalc()
    {
        HPinit();
        ParamInit();
        SaveBasicStats();
        SetActiveSkills();
        SkillInit();
    }
    public void HPinit() //считаем жизни
    {
        hitPoint = vitality * 10 + strength * 5 + level * vitality;
        currentHitPoint = hitPoint;
    }
    public void ParamInit()// считаем параметры
    {
        minDMG = 1 + strength;
        maxDMG = 3 + strength;

        criticalChance = 0 + (2 * agility);
        criticalMF = 2;
        criticalDMG = (int)(maxDMG * criticalMF);
        dodge = 0 + (int)(0.5 * agility);
        armor = (int)(vitality / 2);
        initiative = 0 + (int)(agility / 2) + (int)(strength / 2);
    }
    private void SkillInit()//привязываем скилы
    {
        for (int i = 0; i < activeSkills.Length; i++)
        {
            if (activeSkills[i] != null)
            {

                activeSkills[i].GetComponent<Skills>().Init(gameObject.GetComponent<Unit>());

            }
        }
    }

    private void SaveBasicStats() // сохраняем базовые статы
    {
        basicStats[0] = strength;
        basicStats[1] = agility;
        basicStats[2] = vitality;
    }
    private void ResetStats() //восстанавливаем статы в базовые
    {
        strength = basicStats[0];
        agility = basicStats[1];
        vitality = basicStats[2];

    }
    private void FullReset() //полная перезагрузка перса
    {
        ResetStats();
        HPinit();
        ParamInit();
        effectSkills.Clear();
    }

    public void SetDamage(int[] info) //уменьшить жизнь, получить урон
    {
        //info[0] - dmg
        //info[1] - crit, 1 - true, 0 - false, -1 - effect
        if (info[1] == -1)
        {
            ViewDamage(info);
        }
        else
        {
            int[] result = new int[2];
            int dmg = info[0];
            int chance = Random.Range(0, 100);
            
            dmg -= armor;

            if (dmg < 1)
            {
                dmg = 1;
            }


            if (chance > (100 - dodge))
            {
                dmg = 0;
            }
            result[0] = dmg;
            result[1] = info[1];

            currentHitPoint -= dmg;
            ViewDamage(result);
            
        }

    }
    public void AddEffect(GameObject skill)//добавить эффект из скила
    {
        Skills effect = skill.GetComponent<Skills>();
        if (effect.duration > 0)
        {
            effectSkills.Add(effect);
        }
    }

    public void ActivateEffect() //процесс запуска эффекта
    {
        ResetStats();
        ParamInit();
        for (int i = 0; i < effectSkills.Count; i++)
        {
            int[] info = effectSkills[i].Effect();
            BuffEffect(info);
            effectSkills[i].durationTimer--;
          //  print("Имя юнита: " + this.name + " !!!!! Эффект: " + effectSkills[i]._name + " !!!! время: " + effectSkills[i].durationTimer);

        }

        DeleteEffect();
    }
    private void DeleteEffect() //удаляем эффект duration < 1;
    {
        for (int i = 0; i < effectSkills.Count; i++)
        {
            if (effectSkills[i].durationTimer < 1)
            {
                print(effectSkills[i]._name + " удален");
                effectSkills.RemoveAt(i);

            }
        }
    }

    private void BuffEffect(int[] info) //логика запуска эффекта
    { // info[0] - count, info[1] - stats:
        // 0 - HP
        // 1 - strenght
        // 2 - agility
        // 3 - vitality
        // 4 - dmg (mf)
        int count = info[0];
        int stats = info[1];
        if (stats == 0)
        {
            currentHitPoint -= count;

            int[] view = new int[2];
            view[0] = count;
            view[1] = 0;
            ViewDamage(view);
        }
        else if (stats == 1)
        {
            strength -= count;
            ParamInit();
        }
        else if (stats == 2)
        {
            agility -= count;
            ParamInit();
        }
        else if (stats == 3)
        {
            vitality -= count;
            ParamInit();
        }
        else if (stats == 4)
        {
            minDMG *= count;
            maxDMG *= count;
            print("MinDMG " + minDMG + " MaxDMG " + maxDMG + " !!!!!!!!!!! " + gameObject.name);

        }
        else { print(" не понятный стат в дебафе"); }


    }

    private void SetActiveSkills() //замена, чтобы у каждого был свой скилл, у каждого свой кулдаун и пр...
    {
        for (int i = 0; i < currentSkills.Length; i++)
        {
            if (currentSkills[i] != null && activeSkills[i] == null)
            {
                activeSkills[i] = new GameObject();
                activeSkills[i].AddComponent<Image>();
                activeSkills[i].GetComponent<Image>().sprite = currentSkills[i].GetComponent<Image>().sprite;


                activeSkills[i].AddComponent(currentSkills[i].GetComponent<Skills>().GetType());
            }



        }
    }

   
    private void ViewDamage(int[] info)
    {
        gameObject.GetComponent<toViewDamage>().Init(info, gameObject);
    }



}
