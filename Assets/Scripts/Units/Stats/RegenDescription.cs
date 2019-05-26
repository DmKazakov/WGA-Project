using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenDescription : TxtSkills
{
    public override void Init()
    {
        int reload = gameObject.GetComponent<Skills>().cooldown;
        int duration = gameObject.GetComponent<Skills>().duration;
         txt = "Регенерация." + '\n' + "Перезарядка: " + reload + '\n'+"Длительность: "+duration + '\n' + "Восстанавливает здоровье цели каждый ход. Сила восстановления зависит от максимального здоровья персонажа.";
        gameObject.GetComponent<Skills>().description = txt;
    }

}
