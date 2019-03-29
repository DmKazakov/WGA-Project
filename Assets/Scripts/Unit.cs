using UnityEngine;

public class Unit : MonoBehaviour {
    public int level;

    public int freeStatPoints;
    public int strength;
    public int agility;
    public int vitality;

    public int hitPoint;
    public float criticalChance;
    public float criticalMF;
    public int criticalDMG;
    public float dodge;
    public int armor;
    public int initiative;

    public int minDMG;
    public int maxDMG;

    public Skills[] currentSkills = new Skills[3];

    public void Init() {
        level = 1;
        freeStatPoints = 4;
        strength = 5;
        agility = 5;
        vitality = 5;
        
    }
	
	public void Recalc() {
        hitPoint = vitality * 10 + strength * 5 + level * vitality;
        criticalChance = 0 + (2 * agility);
        criticalMF = 2;
        criticalDMG = (int)(maxDMG * criticalMF);
        dodge = 0 +(int) (0.5 * agility);
        armor = (int)(vitality / 2);
        initiative = 0 + (int)(agility / 2) + (int)(strength / 2);
        minDMG = 1 + strength;
        maxDMG = 3 + strength;
    }
    public int Attack(double mf) {
       
        int i = Random.Range(minDMG, maxDMG);
        int result = (int)(i * mf);
        return result;
    }
}
