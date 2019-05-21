using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDialog : MonoBehaviour
{
    private string[] txtPlayer; //1
    private string[] txtNPC; //2
    private int[] rulesTxt; //3 - END dialog

    // Start is called before the first frame update
    public void Init()
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
        rulesTxt = new int[17] { 2, 1, 2, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 3 };
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
        rulesTxt = new int[11] { 2, 1, 2, 2, 1, 2, 2, 1, 2, 2, 3 };

        txtPlayer = new string[3];
        txtPlayer[0] = "Я выполнила свою часть сделки. Теперь дело за тобой, Фёдор.";
        txtPlayer[1] = "Ты же говорил, что у тебя есть информация.";
        txtPlayer[2] = "Андроид, интересно… Стоит проверить";

        txtNPC = new string[7];
        txtNPC[0] = "Усилитель у тебя, хорошая работа!";
        txtNPC[1] = "Благодаря тебе теперь я могу подключиться к Сети и найти нужную информацию.";
        txtNPC[2] = "Но мне нужно кое-какое время, чтобы все настроить.";
        txtNPC[3] = "Да, я слыхал, что в гаражах одна местная ОПГ торгует редкими имплантами.";
        txtNPC[4] = "Поговаривают, там даже можно найти части андроида.";
        txtNPC[5] = "Сходи разведай обстановку. А как вернешься, я уже закончу с подключением.";
        txtNPC[6] = "Но будь осторожна, там может быть очень опасно.";

        print("инициализация закончена Правила: " + rulesTxt.Length + " Глава: " + Story.chapter);
    }
    private void ChapterOneFinish()
    {
        rulesTxt = new int[11] { 2, 1, 2, 2, 1, 2, 2, 1, 2, 2, 3 };

        txtPlayer = new string[3];
        txtPlayer[0] = "Я выпо";
        txtPlayer[1] = "Ты ж.";
        txtPlayer[2] = "Анд";

        txtNPC = new string[7];
        txtNPC[0] = "Ус";
        txtNPC[1] = "Бла";
        txtNPC[2] = "Но";
        txtNPC[3] = "Да";
        txtNPC[4] = "Пог";
        txtNPC[5] = "Сх";
        txtNPC[6] = "Но бу";

    }

    public string[] GetPlayertxt()
    {

        return txtPlayer;
    }
    public string[] GetNPCtxt()
    {

        return txtNPC;
    }
    public int[] GetRulseDialog()
    {

        return rulesTxt;
    }
}
