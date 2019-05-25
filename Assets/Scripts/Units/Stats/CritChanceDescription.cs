using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CritChanceDescription : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Шанс критического удара" + '\n' + "Шанс нанести максимальный урон" +
                                    '\n' + '\n' + "Пуля - дура, вдруг попадет! ©А.Твардовский";


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
