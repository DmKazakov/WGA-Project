using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MeleeAttack //наследуемся от Skills

{

    public override void Init(Unit unit)
    {
        this.unit = unit;
        _name = "Дальний бой";
        trigger = "range";
        triggerEffect = "";
        mf = 1;
        cooldown = 0;
        duration = 0;
    }

    //прописать с 0 урон в зависимости от оружия
}
