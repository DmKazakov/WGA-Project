using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DEXdescription : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Ловкость" + '\n' + "Влияет на шанс критического удара, уворот и инициативу" + '\n' + '\n' + "Тройной тулуп и ты не труп! ©Расплющенко";


    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.text = descriprion;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        txt.text = "";

    }
    //ловкость рук и никакого мошенничества
    //Тройной тулуп и ты не труп!
}
