using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public GameObject[] squad = new GameObject[3];
    public string sceneName;
    public Transform transform;
    public Sprite location;
    public GameObject getUnit(int num) {
        return squad[num];
    }
    public void Start()
    {
        transform = gameObject.transform;
    }

    public void AddUnitSquad(int num)
    {
        GameObject unit = squad[0].GetComponent<SkillsPull>().teammates[num];
        squad[1] = unit;
        
    }
}
