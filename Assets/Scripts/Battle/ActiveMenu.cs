using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMenu : MonoBehaviour

{
    //  public GameObject battleManager;
    public GameObject[] button = new GameObject[3];
    public Image[] imageCooldown = new Image[3];
    public GameObject emptypoint;

    public void ToTarget(int num) //включаем возможность выбора на юнитах
    {

        GameObject activeSkill = BattleManager.units[0].GetComponent<Unit>().activeSkills[num]; 
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
        CoolDownView(units[0]);
        SwitchCooldownImage(units[0]);
        gameObject.SetActive(true);

    }
    private void SetIcon(GameObject unit)
    { // ставим иконки на кнопки скилов
        int count = unit.GetComponent<Unit>().activeSkills.Length;
        for (int i = 0; i < count; i++)
        {
            if (unit.GetComponent<Unit>().activeSkills[i] == null)
            {
                button[i].GetComponent<Image>().sprite = emptypoint.GetComponent<Image>().sprite;
                button[i].GetComponent<Button>().interactable = false;
                imageCooldown[i].gameObject.SetActive(false);
            }
            else
            {
                button[i].GetComponent<Image>().sprite = unit.GetComponent<Unit>().activeSkills[i].GetComponent<Image>().sprite;
                imageCooldown[i].gameObject.SetActive(true);
            }
        }
    }
    private void SetListener(GameObject unit)
    { //назначаем действие для кнопок
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

    private void CoolDownView(GameObject unit)
    {
        for (int i = 0; i < imageCooldown.Length; i++)
        {
            if (unit.GetComponent<Unit>().activeSkills[i] != null)
            {

                int cooldownCount = unit.GetComponent<Unit>().activeSkills[i].GetComponent<Skills>().GetCooldown();
                int cooldownTimer = unit.GetComponent<Unit>().activeSkills[i].GetComponent<Skills>().cooldownTimer;

                if (cooldownCount == 0)
                {
                    imageCooldown[i].fillAmount = 0;
                }
                else
                {
                    float delta = 100 / cooldownCount;
                    imageCooldown[i].fillAmount = (cooldownTimer * delta) / 100;
                }

            }
        }
    }
    private void SwitchCooldownImage(GameObject unit)
    {
        for (int i = 0; i < unit.GetComponent<Unit>().activeSkills.Length; i++)
        {
            if (unit.GetComponent<Unit>().activeSkills[i] != null)
            {


                int cooldownCount = unit.GetComponent<Unit>().activeSkills[i].GetComponent<Skills>().cooldownTimer;
                if (cooldownCount > 0)
                {
                    button[i].GetComponent<Button>().interactable = false;
                }
                else
                {
                    button[i].GetComponent<Button>().interactable = true;
                }
            }
        }
    }


}
