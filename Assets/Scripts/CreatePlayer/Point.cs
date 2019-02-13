using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject text;
    public GameObject hero;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Unit component = hero.GetComponent<Unit>();

        switch (text.name)
        {
            case "StrP":
                text.GetComponent<Text>().text = component.strength.ToString();
                break;
            case "DexP":
                text.GetComponent<Text>().text = component.agility.ToString();
                break;
            case "VitP":
                text.GetComponent<Text>().text = component.vitality.ToString();
                break;
            case "EmptyP":
                text.GetComponent<Text>().text = component.freeStatPoints.ToString();
                break;
            default:
                text.GetComponent<Text>().text = "0";
                break;
        }
    }
}
