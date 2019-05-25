using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VITdescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion = "Выносливость" + '\n' + "Влияет на броню, количество здоровья и на то, сколько здоровья прибавит новый уровень" + 
                                    '\n' + '\n' + "У здорового тела - турник во дворе! ©Физрук";


    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.text = descriprion;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        txt.text = "";

    }
}
