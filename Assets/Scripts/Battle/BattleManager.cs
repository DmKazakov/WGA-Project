﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading;

public class BattleManager : MonoBehaviour
{

    // Start is called before the first frame update
    public static List<GameObject> units;
    public GameObject activeMenu;
    internal static GameObject target;
    public GameObject[] orderPanel = new GameObject[6];



    internal void Fight(int dmg)
    {
        //весь процесс боя
        target.GetComponent<Unit>().currentHitPoint -= dmg;
        String tXt = "Нанесен урон " + dmg + " по " + target.name + " осталось ХП: " + target.GetComponent<Unit>().currentHitPoint + "/" + target.GetComponent<Unit>().hitPoint;

        if (target.tag.Equals("Enemy"))
        {
            Debug.Log("<color=blue>" + tXt + "</color>");
        }
        else
        {
            Debug.Log("<color=red>" + tXt + "</color>");
        }
        



        for (int i = 0; i < units.Count; i++)
        {
            if (units[i].tag.Equals("Enemy"))
            {
                units[i].GetComponent<SelectUnit>().select = false;
            }
        }
        EndRound();


    }

    internal void ToBattle(List<GameObject> units)
    {
        BattleManager.units = units;
        Sort();
        OrderPanelplace();
        ReplaceActiveMenu();
            }

    internal void Sort()
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
    internal void ReplaceActiveMenu()
    {
        activeMenu.transform.position = units[0].transform.position;
        if (units[0].tag.Equals("Player"))
        {
            activeMenu.SetActive(true);
        }
        else
        {
            int dmg = units[0].GetComponent<Unit>().Attack(1);
            activeMenu.SetActive(false);
            BattleAI.ChoiceTarget();
          //  print(units[0].name + " ударил " + target.name + " на " + dmg + "осталось ХП " + target.GetComponent<Unit>().hitPoint);
            Fight(dmg);
            
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
                print("юнит: "+ currentUnit.name + " умер");
                units.RemoveAt(i);
            }
        }

        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] enemyes = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemyes.Length < 1)
        {
            print("win!");
            //добавить уничтожение всех объектов, чтобы по tag Player находился только один (Аватар)
        }
        else if (players.Length < 1)
        {
            print("Game Over");
        }
        else
        {
            units.Add(units[0]);
            units.RemoveAt(0);  //двигаем очередь
            OrderPanelplace();  //отображаем очередь на панели
            Invoke("ReplaceActiveMenu", 0.5f); //задрежка для проверки, удалить потом
           // ReplaceActiveMenu(); активировать после удаления
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
    }
}
