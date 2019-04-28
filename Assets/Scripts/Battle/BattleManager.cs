using System.Collections;
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
    public GameObject viewDamage;



    internal void Fight(int dmg)
    {
        //весь процесс боя
        target.GetComponent<Unit>().currentHitPoint -= dmg; //вместо этого вызываем метод получения дмг
        PrintRound(dmg);
        ViewDmg(dmg);


        for (int i = 0; i < units.Count; i++)
        {
            if (units[i].tag.Equals("Enemy"))
            {
                units[i].GetComponent<SelectUnit>().select = false;
            }
        }


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
            activeMenu.SetActive(false);
            int dmg = units[0].GetComponent<Unit>().Attack(1);

            BattleAI.ChoiceTarget();
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
                print("юнит: " + currentUnit.name + " умер");
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
    void ViewDmg(int dmg)
    {
        GameObject dmgView = Instantiate(viewDamage, target.transform.position, Quaternion.identity);
        dmgView.GetComponent<ViewDamage>().Init(dmg);
        dmgView.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        dmgView.transform.position = target.transform.position;
    }//визуализация урона
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
}
