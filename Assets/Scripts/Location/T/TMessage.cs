using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMessage : MessageText
{
    public override void Init()
    {
        txt = new string[1];
        txt[0] = @"Это что еще за пылесос?!
А ну вали отсюда, пока не разобрали!";
        //txt[1] = "А ну вали отсюда, пока не разобрали!";
    }
}
