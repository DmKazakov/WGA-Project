using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PerkClinki : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Тяжелые клинки" + '\n' + "Увеличивает максимальный урон персонажа на 2." +
                                    '\n' + '\n' + "Слабоумие и отвага! ©Алеша Портович";


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
