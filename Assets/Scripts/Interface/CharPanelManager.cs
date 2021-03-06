﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharPanelManager : MonoBehaviour
{


    public GameObject[] squad = new GameObject[2];
    internal Unit currentUnit;

    public Image unitImage;
    public Image skill;
    public Text[] statspoint;
    public Image emptyskill;


    public void Init()
    {
        InitStats();
        unitImage.sprite = currentUnit.GetComponent<SpriteRenderer>().sprite;

        gameObject.GetComponent<ButtonManager>().SwitchButtonState();
        InitSkill();

    }



    public void SwitchUnit(int i)
    {

        currentUnit = squad[i].GetComponent<Unit>();
        currentUnit.Recalc();
        Init();
    }

    private void InitStats()
    {
        statspoint[0].text = currentUnit.strength.ToString();
        statspoint[1].text = currentUnit.agility.ToString();
        statspoint[2].text = currentUnit.vitality.ToString();
        statspoint[3].text = currentUnit.minDMG.ToString();
        statspoint[4].text = currentUnit.maxDMG.ToString();
        statspoint[5].text = currentUnit.hitPoint.ToString();
        statspoint[6].text = currentUnit.criticalChance.ToString();
        statspoint[7].text = currentUnit.criticalDMG.ToString();
        statspoint[8].text = currentUnit.initiative.ToString();
        statspoint[9].text = currentUnit.armor.ToString();
        statspoint[10].text = currentUnit.dodge.ToString();
        statspoint[11].text = currentUnit.perkEmpty.ToString();

    }
    private void InitSkill()
    {
        Skills skl = currentUnit.currentSkills[2].GetComponent<Skills>();
        TxtSkills txtskill = currentUnit.currentSkills[2].GetComponent<TxtSkills>();
        if (skl != null)
        {
            currentUnit.currentSkills[2].GetComponent<Skills>().Init(currentUnit);
            txtskill.Init();
            string ttt = txtskill.txt;
            skill.sprite = skl.spriteON;
            skill.gameObject.transform.GetComponent<SkillDescription>().SetDescripion(ttt);
          
        }
        else
        {
            skill.sprite = emptyskill.sprite;
        }
    }
}
