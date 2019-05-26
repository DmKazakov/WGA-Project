using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimDescription : TxtSkills
{
    public override void Init()
    {
        int reload = gameObject.GetComponent<Skills>().cooldown;
        int duration = gameObject.GetComponent<Skills>().duration;
         txt = "Прицеливание." + '\n' + "Перезарядка: " + reload +'\n' + "Длительность: " + duration + '\n' + "Следующий удар нанесет тройной урон";
        gameObject.GetComponent<Skills>().description = txt;
    }
}
