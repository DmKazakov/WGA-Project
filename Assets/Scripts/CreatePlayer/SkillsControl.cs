using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsControl : MonoBehaviour
{
    public GameObject skill0;
    public GameObject skill1;
    public GameObject skill2;
    private Skills[] skills;
    // Start is called before the first frame update
    void Start()
    {
        skills = new Skills[3];
        skills[0] = skill0.GetComponent<Skills>();
        skills[1] = skill1.GetComponent<Skills>();
        skills[2] = skill2.GetComponent<Skills>();

        skill0.GetComponent<Button>().onClick.AddListener(() => SwitchSkills(0));
        skill1.GetComponent<Button>().onClick.AddListener(() => SwitchSkills(1));
        skill2.GetComponent<Button>().onClick.AddListener(() => SwitchSkills(2));
    }


    // Update is called once per frame
    void SwitchSkills(int num) {
        for (int i = 0; i < skills.Length; i++) {
            //меняем все на неактивные
            skills[i].isCurrent = false;
            //меняем прозрачность
            ChangeColorButton(i, false);
            

        }
           //нужный делаем активным и убираем прозрачность
        skills[num].isCurrent = true;
        ChangeColorButton(num, true);
        

    }

    void ChangeColorButton(int num, bool active) {
        Button button = skills[num].GetComponent<Button>();
        ColorBlock colorVar = button.colors;

        if (active)
        {
            colorVar.normalColor = new Color(colorVar.normalColor.r, colorVar.normalColor.g, colorVar.normalColor.b, 1f);
        }
        else
        {
            colorVar.normalColor = new Color(colorVar.normalColor.r, colorVar.normalColor.g, colorVar.normalColor.b, 0.3f);
        }

        button.colors = colorVar;
    }

    
}
