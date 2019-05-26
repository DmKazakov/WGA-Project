using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PerkReaction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Реакция" + '\n' + "Увеличивает скорость восстановления навыков" +
                                    '\n' + '\n' + "Решающий аргумент - вовремя перезаряжай! ©Дэниэл Веслон";


    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.text = descriprion;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        txt.text = "";

    }
    //Решающий аргумент - держи на предохранителе! - на скилл прицеливание
    //Просто добавь брони - перк броня
    //Слабоумие и отвага
}
