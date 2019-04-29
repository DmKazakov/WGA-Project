using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsPull : MonoBehaviour
{
    public List<GameObject> skillsPull = new List<GameObject>();
    public GameObject emptySkill;

    

    public GameObject getSkill(string skill)
    {
        GameObject original = emptySkill;
        for (int i = 0; i < skillsPull.Count; i++)
        {
            if (skillsPull[i].name.Equals(skill))
            {
                original = skillsPull[i];
            }
        }
        return original;
    }
}
