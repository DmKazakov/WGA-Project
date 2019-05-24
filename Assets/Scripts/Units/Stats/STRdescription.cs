using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class STRdescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Сила"+'\n'+"Влияет на силу удара и инициативу"+'\n'+'\n'+ "Чем больше сила тем больше ответственность! ©Дядя Бен";


    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.text = descriprion;
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        txt.text = "";
        
    }
}
