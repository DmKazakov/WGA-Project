using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsDescription : TxtSkills
{
    // Start is called before the first frame update
    public override void Init()
    {
        
        int reload = gameObject.GetComponent<Skills>().cooldown;
        int duration = gameObject.GetComponent<Skills>().duration;
        txt = "Глубокие порезы." + '\n' + "Базовая перезарядка: " + reload +'\n' + "Длительность: " + duration + '\n' + "После удара вызвает кровотечение у цели. Сила кровотечения зависит от урона персонажа";
        gameObject.GetComponent<Skills>().description = txt;
    }

}


