using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDialog : MonoBehaviour
{
    private string[] txtPlayer; //1
    private string[] txtNPC; //2
    private int[] rulesTxt; //3 - END dialog

    // Start is called before the first frame update
  public  void Init()
    {
        if (Story.chapter == 1.0)
        {
            FirstDialog();
        }
        else if (Story.chapter == 1.2)
        {
            SchoolFinish();
        }
        else if (Story.chapter == 1.4)
        {
            ChapterOneFinish();
        }
        else
        {
            txtNPC = new string[1] { "нет диалога" };
            txtPlayer = new string[1] { "нет диалога" };
            rulesTxt = new int[3] { 1, 2, 3 };
        }
    }

    private void FirstDialog()
    {
        rulesTxt = new int[17] { 2, 1, 2, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2,2,2, 3 };
        //1
        txtPlayer = new string[3];
        txtPlayer[0] = "Где я?";
        txtPlayer[1] = "Такие как я?";
        txtPlayer[2] = "Похоже у меня нет выбора.";
        //2
        txtNPC = new string[13];
        txtNPC[0] = "Спокойно! Здесь врагов нет. Опусти кулаки";

        txtNPC[1] = "Добро пожаловать в мою мастерскую. Меня зовут Фёдор, я ... А, впрочем, тебе пока хватит этой ";
        txtNPC[2] = "информации";
        txtNPC[3] = "Не думал что такие как ты и вправду существуют.";

        txtNPC[4] = "Да, андроиды, много слухов ходит, но я всегда считал это фантазией идеалистов. ";
        txtNPC[5] = "Я бы тебе рассказал все, но есть одно очень срочное дело.";
        txtNPC[6] = "Заключим сделку, ты поможешь мне, а я расскажу, что знаю.";

        txtNPC[7] = "Тогда слушай и запоминай. Сейчас с властями мы не дружим и они всячески стараются ";
        txtNPC[8] = "усложнить нам жизнь.";
        txtNPC[9] = "На этот раз они лишили нас связи, но есть идея как ее вернуть.";
        txtNPC[10] = "Принеси мне усилитель сигнала из старой мастерской, она в школе. ";
        txtNPC[11] = "Найдеш ее в сеседнем квартале, не заблудишься.";
        txtNPC[12] = "И возьми с собой САОП - 2, он защитит тебя от проблем.";
    }
    private void SchoolFinish()
    {
        rulesTxt = new int[5] { 1, 2, 1, 2, 3 };

        txtPlayer = new string[2];
        txtPlayer[0] = "тут диалог 1";
        txtPlayer[1] = "диалог2";

        txtNPC = new string[2];
        txtNPC[0] = "3";
        txtNPC[1] = "222";
    }
    private void ChapterOneFinish()
    {
        rulesTxt = new int[5] { 1, 2, 1, 2, 3 };

        txtPlayer = new string[2];
        txtPlayer[0] = "тут диалог 1";
        txtPlayer[1] = "диалог2";

        txtNPC = new string[2];
        txtNPC[0] = "3";
        txtNPC[1] = "222";
    }

    public string[] GetPlayertxt() {
       
        return txtPlayer;
    }
    public string[] GetNPCtxt() {
       
        return txtNPC;
    }
    public int[] GetRulseDialog() {
        
        return rulesTxt;
    }
}
