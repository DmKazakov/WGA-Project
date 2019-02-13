using UnityEngine;

public class Unit : MonoBehaviour {
    public int level;

    public int freeStatPoints;
    public int strength;
    public int agility;
    public int vitality;

    private int hitPoint;
    private float criticalChance;
    private float criticalMF;
    private int criticalDMG;
    private float dodge;
    private int armor;
    private int initiative;

    private int minDMG;
    private int maxDMG;

    public void Init() {
        level = 1;
        freeStatPoints = 7;
        strength = 1;
        agility = 2;
        vitality = 3;
    }
	
	public void Recalc() {
        hitPoint = vitality * 10 + strength * 5 + level * vitality;
        criticalChance = 0 + (2 * agility);
        criticalMF = 2;
        criticalDMG = (int)(maxDMG * criticalMF);
        dodge = 0 + (2 * agility);
        armor = (int)(vitality / 2);
        initiative = 0 + (int)(agility / 2) + (int)(strength / 2);
        minDMG = 1 + strength;
        maxDMG = 1 + strength;
    }
}
