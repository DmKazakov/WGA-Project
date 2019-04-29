using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class SkillsControl : MonoBehaviour
{

    public GameObject[] skills;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        skills[0].GetComponent<Button>().onClick.AddListener(() => SwitchSkills(0));
        skills[1].GetComponent<Button>().onClick.AddListener(() => SwitchSkills(1));
        skills[2].GetComponent<Button>().onClick.AddListener(() => SwitchSkills(2));

    }

    // Update is called once per frame
    void SwitchSkills(int num)
    {

        print(num);
        SwitchSprite();
        player.GetComponent<Unit>().currentSkills[2] = player.GetComponent<SkillsPull>().getSkill(skills[num].name);


        skills[num].GetComponent<Image>().sprite = skills[num].GetComponent<Skills>().spriteON;


    }

    //void ChangeColorButton(int num, bool active) {
    //    Button button = skills[num].GetComponent<Button>();
    //    ColorBlock colorVar = button.colors;
    //
    //    if (active)
    //    {
    //        colorVar.normalColor = new Color(colorVar.normalColor.r, colorVar.normalColor.g, colorVar.normalColor.b, 1f);
    //    }
    //    else
    //     {
    //         colorVar.normalColor = new Color(colorVar.normalColor.r, colorVar.normalColor.g, colorVar.normalColor.b, 0.3f);
    //     }

    //     button.colors = colorVar;
    // }
    void SwitchSprite()
    {
        for (int i = 0; i < skills.Length; i++)
        {
            skills[i].GetComponent<Image>().sprite = skills[i].GetComponent<Skills>().spriteOFF;
        }
    }



}
