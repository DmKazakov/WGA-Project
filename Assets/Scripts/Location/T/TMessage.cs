using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMessage : MessageText
{
    public override void Init()
    {
        txt = new string[2];
        txt[0] = "Это что еще за пылесос?!";
        txt[1] = "А ну вали отсюда, пока не разобрали!";
    }
}
