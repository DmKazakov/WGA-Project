using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DMGdescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Урон" + '\n' + "Количество наносимых повреждений по врагу" +
                                    '\n' + '\n' + "Много - не мало, но больно! ©Жизнь";


    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.text = descriprion;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        txt.text = "";

    }
}
