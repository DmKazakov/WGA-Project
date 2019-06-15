using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDialog : MonoBehaviour
{
    //крепется к менеджеру

    private string[] txtPlayer; //1
    private string[] txtNPC; //2
    private int[] rulesTxt; //3 - END dialog
    private Unit[] speakers;
    public Unit[] allRoomSpeakers;
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
        else if (Story.chapter == 1.5)
        {
            SisterDialog();
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
        speakers = new Unit[] { allRoomSpeakers[0], allRoomSpeakers[1] };
        rulesTxt = new int[17] { 2, 1, 2, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 3 };
        //1
        txtPlayer = new string[3];
        txtPlayer[0] = "Где я?";
        txtPlayer[1] = "Такие как я?";
        txtPlayer[2] = "Похоже, у меня нет выбора.";
        //2
        txtNPC = new string[13];
        txtNPC[0] = "Спокойно! Здесь врагов нет. Опусти кулаки.";

        txtNPC[1] = "Добро пожаловать в мою мастерскую. Меня зовут Фёдор, я … ";
        txtNPC[2] = "А, впрочем, тебе пока хватит этой информации";
        txtNPC[3] = "Не думал, что такие как ты и вправду существуют.";

        txtNPC[4] = "Да, андроиды, много слухов ходит, но я всегда считал это фантазией идеалистов. ";
        txtNPC[5] = "Я бы тебе рассказал все, но есть одно очень срочное дело.";
        txtNPC[6] = "Заключим сделку, ты поможешь мне, а я расскажу, что знаю.";

        txtNPC[7] = "Тогда слушай и запоминай. Сейчас с властями мы не дружим, и они всячески стараются ";
        txtNPC[8] = "усложнить нам жизнь.";
        txtNPC[9] = "На этот раз они лишили нас связи, но есть идея, как ее вернуть.";
        txtNPC[10] = "Принеси мне усилитель сигнала из старой мастерской, она в школе. ";
        txtNPC[11] = "Найдеш ее в соседнем квартале, не заблудишься.";
        txtNPC[12] = "И возьми с собой САОП - 2 (Самоходный Аппарат Обеспечения Порядка), он защитит тебя.";
    }
    private void SchoolFinish()
    {
        speakers = new Unit[] { allRoomSpeakers[0], allRoomSpeakers[1] };
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

        
    }
    private void ChapterOneFinish()
    {
        speakers = new Unit[] { allRoomSpeakers[0], allRoomSpeakers[1] };
        rulesTxt = new int[6] { 2, 2, 1, 2, 2, 3};

        txtPlayer = new string[1];
        txtPlayer[0] = "Скорее то, что от неё осталось. Сможешь включить?";


        txtNPC = new string[4];
        txtNPC[0] = "Ты как раз вовремя, я только закончил подключение.";
        txtNPC[1] = "Это что … ещё один андроид?!";

        txtNPC[2] = "Дай посмотрю… Хм, интересно…";
        txtNPC[3] = "Диагностика показала, что основные модули не повреждены. Сейчас подключу её к питанию.";


    }

    private void SisterDialog()
    {
        speakers = new Unit[] { allRoomSpeakers[0], allRoomSpeakers[2] };
        rulesTxt = new int[6] { 2, 1, 2, 1, 2, 3 };

        txtPlayer = new string[2];
        txtPlayer[0] = "Теперь ты в безопасности. Я тебе помогу.";
        txtPlayer[1] = "Тебе известно, где я могу найти других андроидов?";

        txtNPC = new string[3];
        txtNPC[0] = "Голова раскалывается… Что произошло?";
        txtNPC[1] = "Спасибо тебе, сестричка. Немного нас осталось. Как я могу тебе отплатить?";
        txtNPC[2] = "Да, я расскажу тебе всё, что знаю.";
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
    public Unit[] GetHeadSpeaker() {
        return speakers;
    }
}
