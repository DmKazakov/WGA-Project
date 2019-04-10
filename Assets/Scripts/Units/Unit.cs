using UnityEngine;

public abstract class Unit : MonoBehaviour {
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
    public GameObject[] team = new GameObject[3];

    public Sprite moveSprite;
    public Sprite battleSprite;

    public GameObject[] squad = new GameObject[2];

    public abstract int Attack(double mf); 
}
