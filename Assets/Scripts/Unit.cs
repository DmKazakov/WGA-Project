using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
    public int personlevel;

    public int emptypoints;
    public int strength;
    public int dextery;
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
    // Use this for initialization
    void Start () {
        personlevel = 1;
        emptypoints = 7;
        strength = 1;
        dextery = 2;
        vitality = 3;
    }
	
	// Update is called once per frame
	void Update () {
        hitPoint = vitality * 10 + strength * 5 + personlevel * vitality;
        criticalChance = 0 + (2 * dextery);
        criticalMF = 2;
        criticalDMG = (int)(maxDMG * criticalMF);
        dodge = 0 + (2 * dextery);
        armor = (int)(vitality / 2);
        initiative = 0 + (int)(dextery / 2) + (int)(strength / 2);
        minDMG = 1 + strength;
        maxDMG = 1 + strength;
    }
}
