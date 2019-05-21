using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolMessage : MessageText
{
    
   
    public override void Init()
    {
        txt = new string[2];
        txt[0] = "Отдышавшись немного после боя вы обыскиваете трупы и находите усилитель.";
        txt[1] = "Пора возвращаться к Фёдору";
    }
}
