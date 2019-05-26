using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PerSplav : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Прочный сплав" + '\n' + "Увеличивает броню персонажа на 1." +
                                    '\n' + '\n' + "Просто добавь брони! ©Трупи";


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
