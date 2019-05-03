using UnityEngine;
using UnityEngine.UI;


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
    public GameObject[] activeSkills = new GameObject[3];
    

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

        SetActiveSkills();
        SkillInit();
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

    private void SetActiveSkills() { //замена, чтобы у каждого был свой скилл, у каждого свой кулдаун и пр...
        for (int i = 0; i < currentSkills.Length; i++)
        {
            if (currentSkills[i] != null && activeSkills[i]==null)
            {
                activeSkills[i] = new GameObject();
                activeSkills[i].AddComponent<Image>();
                activeSkills[i].GetComponent<Image>().sprite = currentSkills[i].GetComponent<Image>().sprite;


                activeSkills[i].AddComponent(currentSkills[i].GetComponent<Skills>().GetType());
            }
            


        }
    }

    public int GetDamage() {
        return dmg;
    }
    private void SkillInit() {
        for (int i = 0; i < activeSkills.Length; i++)
        {
            if (activeSkills[i] != null)
            {


                activeSkills[i].GetComponent<Skills>().Init(gameObject.GetComponent<Unit>());
               
            }
        }
    }


}
