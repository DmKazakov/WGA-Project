using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMenu : MonoBehaviour
    
{
  //  public GameObject battleManager;
    public GameObject[] button = new GameObject[3];

    public void ToTarget(int num) //включаем возможность выбора на юнитах
    {

        GameObject activeSkill = BattleManager.units[0].GetComponent<Unit>().currentSkills[num];
        BattleManager.skill = activeSkill;

        if (activeSkill.GetComponent<Skills>() is Foe)
        {
            SelectUnit("Enemy");
        }
        else if (activeSkill.GetComponent<Skills>() is Mate)
        {
            SelectUnit("Player");
        }

       
       
    }

    

    internal void ReplaceActiveMenu(List<GameObject> units) //перставляем активное меню
    {
        gameObject.transform.position = units[0].transform.position;
        SetIcon(units[0]);
        SetListener(units[0]);
        gameObject.SetActive(true);

    }
    private void SetIcon(GameObject unit) { // ставим иконки на кнопки скилов
        int count = unit.GetComponent<Unit>().currentSkills.Length;
        for (int i = 0; i < count; i++)
        {
            button[i].GetComponent<Image>().sprite = unit.GetComponent<Unit>().currentSkills[i].GetComponent<Image>().sprite;
        }
    }
    private void SetListener(GameObject unit) { //назначаем действие для кнопок
        button[0].GetComponent<Button>().onClick.AddListener(() => ToTarget(0));
        button[1].GetComponent<Button>().onClick.AddListener(() => ToTarget(1));
        button[2].GetComponent<Button>().onClick.AddListener(() => ToTarget(2));
    }

    private void SelectUnit(string tag) //включаем подсветку
    {
        for (int i = 0; i < BattleManager.units.Count; i++)
        {

            if (BattleManager.units[i].tag.Equals(tag))
            {
                BattleManager.units[i].GetComponent<SelectUnit>().select = true;
            }
            else { BattleManager.units[i].GetComponent<SelectUnit>().select = false; }

        }
    } //включаем нажатие по врагам\союзникам

 
 
}
