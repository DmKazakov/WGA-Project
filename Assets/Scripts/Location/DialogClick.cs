using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogClick : MonoBehaviour
{
    private int count1;
    private int count2;
    public Button panel1;
    public Button panel2;
    public DialogManager manager;
    // Start is called before the first frame update
    void Start()
    {
        Init();
        panel1.onClick.AddListener(onClick1);
        panel2.onClick.AddListener(onClick2);
    }
    public void Init()
    {
        count1 = 0;
        count2 = 0;
    }

    public void onClick1()
    {
        count1++;
        manager.rulesNum++;
        manager.DialogPlay(count1, count2);
        gameObject.GetComponent<AudioSource>().Play();
    }
    public void onClick2()
    {
        count2++;
        manager.rulesNum++;
        manager.DialogPlay(count1, count2);
        gameObject.GetComponent<AudioSource>().Play();
    }
    
}
