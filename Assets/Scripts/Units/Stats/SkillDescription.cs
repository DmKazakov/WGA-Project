using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text txt;
    private string descriprion;


    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.text = descriprion;
        print(descriprion);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        txt.text = "";

    }
    public void SetDescripion(string text)
    {
        descriprion = text;
    }
}
