using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public int level;

    public int freeStatPoints;
    public int strength;
    public int agility;
    public int vitality;

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

    private int dmg;

    public GameObject[] currentSkills = new GameObject[3];

    public Sprite headIcon;



    public void Recalc()
    {
        hitPoint = vitality * 10 + strength * 5 + level * vitality;
        currentHitPoint = hitPoint;
        minDMG = 1 + strength;
        maxDMG = 3 + strength;

        criticalChance = 0 + (2 * agility);
        criticalMF = 2;
        criticalDMG = (int)(maxDMG * criticalMF);
        dodge = 0 + (int)(0.5 * agility);
        armor = (int)(vitality / 2);
        initiative = 0 + (int)(agility / 2) + (int)(strength / 2);


    }

    public void SetDamage(int dmg)
    {
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
        this.dmg = dmg;
        currentHitPoint -= dmg;

    }

    public int GetDamage() {
        return dmg;
    }



}
