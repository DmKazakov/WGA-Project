using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class BattleManager : MonoBehaviour
{

    // Start is called before the first frame update
    public static List<GameObject> units;
    public GameObject activeMenu;
    internal static GameObject target;
    private static Unit targetUnit;
    internal static GameObject skill;
    public GameObject[] orderPanel = new GameObject[6];
    public GameObject viewDamage;



    internal void Fight()
    {
        //весь процесс боя
        targetUnit = target.GetComponent<Unit>();
        activeMenu.SetActive(false);
        SelectOFF();
        // skill.GetComponent<Skills>().Init(units[0].GetComponent<Unit>()); заменено на Unit.skillInit

        int[] dmg = skill.GetComponent<Skills>().Attack();
        targetUnit.SetDamage(dmg); //наносим урон
        

      //  dmg[0] = target.GetComponent<Unit>().GetDamage(); // временно для отображение урона
        PrintRound(dmg[0]);
      //    ViewDmg(dmg[0]);
       // viewDamage.GetComponent<ViewDamage>().toView(dmg, target);
       
        
        EndRound();


    }

    internal void BattleSetup(List<GameObject> units)
    {
        BattleManager.units = units;
        Sort();
        OrderPanelplace();
        StartBattle();
    }
    internal void StartBattle()
    {
        if (units[0].tag.Equals("Player"))
        {
            activeMenu.GetComponent<ActiveMenu>().ReplaceActiveMenu(units);

        }
        else
        {
            //прописать AI

            skill = units[0].GetComponent<Unit>().activeSkills[0];
            BattleAI.ChoiceTarget();
            Fight();

        }
    }

    internal void EndRound()
    {
        for (int i = 0; i < units.Count; i++)
        {

            Unit currentUnit = units[i].GetComponent<Unit>();
            if (currentUnit.currentHitPoint < 1)
            {

                units[i].SetActive(false);
                print("юнит: " + currentUnit.name + " умер");
                units.RemoveAt(i);
            }
        }

        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] enemyes = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemyes.Length < 1)
        {
            print("win!");
            Clear();
            gameObject.GetComponent<StartPoint>().ExitBattle(true);

            //добавить уничтожение всех объектов, чтобы по tag Player находился только один (Аватар)
        }
        else if (players.Length < 1)
        {
            print("Game Over");
            gameObject.GetComponent<StartPoint>().ExitBattle(false);
        }
        else
        {
            UnitUpdate(); //обновление юнитов: откат скила, срабатывание эффекта(кровотечение, лечение)
            units.Add(units[0]);
            units.RemoveAt(0);  //двигаем очередь
            OrderPanelplace();  //отображаем очередь на панели
            Invoke("StartBattle", 0.5f); //задрежка для проверки, удалить потом
                                         // StartBattle(); активировать после удаления
        }

    }
    void OrderPanelplace()
    {
        int k = 0;
        for (int i = 0; i < orderPanel.Length; i++)
        {
            try
            {
                orderPanel[i].GetComponent<Image>().sprite = units[k].GetComponent<Unit>().headIcon;
            }
            catch (Exception)
            {
                k = 0;
                orderPanel[i].GetComponent<Image>().sprite = units[k].GetComponent<Unit>().headIcon;

            }


            k++;
        }
    }// панель очереди
   
    void PrintRound(int dmg)
    {
        String tXt = "Нанесен урон " + dmg + " по " + target.name + " осталось ХП: " + target.GetComponent<Unit>().currentHitPoint + "/" + target.GetComponent<Unit>().hitPoint;

        if (target.tag.Equals("Enemy"))
        {
            Debug.Log("<color=blue>" + tXt + "</color>");
        }
        else
        {
            Debug.Log("<color=red>" + tXt + "</color>");
        }
    }  //текстовое отображение урона, пока нет анимации
    private void Sort()
    {
        GameObject temp;
        for (int i = 0; i < units.Count; i++)
        {
            for (int j = i + 1; j < units.Count; j++)
            {
                if (units[i].GetComponent<Unit>().initiative < units[j].GetComponent<Unit>().initiative)
                {
                    temp = units[i];
                    units[i] = units[j];
                    units[j] = temp;

                }
            }
        }
    }

    private void SelectOFF()
    {
        for (int i = 0; i < units.Count; i++)
        {
            units[i].GetComponent<SelectUnit>().select = false;
        }
    }
    private void UnitUpdate() //запуск кулдауна у скиллов, добавление эффекта, активация эффекта
    {
        CoolDownStart();
        targetUnit.AddEffect(skill); //добавляем эффект скила в список
        units[0].GetComponent<Unit>().ActivateEffect(); //активация эффекта


    }
    private void CoolDownStart()//запуск кулдауна у units[0]
    {
        for (int i = 0; i < units[0].GetComponent<Unit>().activeSkills.Length; i++)
        {
            if (units[0].GetComponent<Unit>().activeSkills[i] != null)
            {
                units[0].GetComponent<Unit>().activeSkills[i].GetComponent<Skills>().DecreaseCoolDown();
            }
        }
    }
    private void Clear() {
        for (int i = 0; i < units.Count; i++)
        {
            units[i].GetComponent<Unit>().effectSkills.Clear();
            Destroy(units[i]);
        }
    }
}
