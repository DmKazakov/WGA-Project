﻿using UnityEngine;

public abstract class Unit : MonoBehaviour {
    public int level;

    public int freeStatPoints;
    public int strength;
    public int agility;
    public int vitality;

    internal int hitPoint;
    internal float criticalChance;
    internal float criticalMF;
    internal int criticalDMG;
    internal float dodge;
    internal int armor;
    internal int initiative;

    internal int minDMG;
    internal int maxDMG;

    public Skills[] currentSkills = new Skills[3];
    public GameObject[] team = new GameObject[3];

    public Sprite moveSprite;
    public Sprite battleSprite;

    public GameObject[] squad = new GameObject[2];

    public abstract int Attack(double mf);
    public void Recalc()
    {
        hitPoint = vitality * 10 + strength * 5 + level * vitality;
        criticalChance = 0 + (2 * agility);
        criticalMF = 2;
        criticalDMG = (int)(maxDMG * criticalMF);
        dodge = 0 + (int)(0.5 * agility);
        armor = (int)(vitality / 2);
        initiative = 0 + (int)(agility / 2) + (int)(strength / 2);
        minDMG = 1 + strength;
        maxDMG = 3 + strength;
    }
}