using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageMessage : MessageText
{
    public override void Init()
    {
        txt = new string[2];
        txt[0] = "Вы изучили запасы бандитов и нашли полуразобранное тело андроида. Кажется, раньше андроид представлял собой молодую девушку.";
        txt[1] = "После неудачных попыток её включить вы решили отнести её Фёдору.";
    }
}
