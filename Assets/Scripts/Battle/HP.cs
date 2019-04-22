using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider slider;
    int maxHP;
    int currentHP;
    private GameObject unit;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = unit.GetComponent<Unit>().hitPoint;
        slider.value = unit.GetComponent<Unit>().currentHitPoint;
        if (slider.value<1)
        {
            Destroy(slider.gameObject);
        }
    }
    public void Init(GameObject game) {
        unit = game;
        slider.handleRect.GetComponent<Image>().sprite = unit.GetComponent<Unit>().headIcon;
        
    }
    
}
