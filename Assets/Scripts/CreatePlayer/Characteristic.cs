using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Characteristic : MonoBehaviour
{
    public GameObject text;
    public GameObject hero;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Unit component = hero.GetComponent<Unit>();

        switch (text.name)
        {
            case "MinDmg":
                text.GetComponent<Text>().text = component.minDMG.ToString();
               
                break;
            case "MaxDmg":
                text.GetComponent<Text>().text = component.maxDMG.ToString();
                break;
            case "HPp":
                text.GetComponent<Text>().text = component.hitPoint.ToString();
                break;
            case "CritChanceP":
                text.GetComponent<Text>().text = component.criticalChance.ToString();
                break;
            case "CritDmgP":
                text.GetComponent<Text>().text = component.criticalMF.ToString();
                break;
            case "DodgeP":
                text.GetComponent<Text>().text = component.dodge.ToString();
                break;
            case "ArmorP":
                text.GetComponent<Text>().text = component.armor.ToString();
                break;
            case "InitiativeP":
                text.GetComponent<Text>().text = component.initiative.ToString();
                break;
            default:
                text.GetComponent<Text>().text = "0";
                break;
        }
    }
}