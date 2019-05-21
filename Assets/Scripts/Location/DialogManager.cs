using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject person1txt;
    public GameObject person2txt;
    public GameObject parentTxt1;
    public GameObject parentTxt2;

    private RoomDialog dialog;
    
    private string[] txt1;
    private string[] txt2;
    private int[] rulesTxt;
    public int rulesNum;


    PlayerKeyboardController thePlayer;
    float initSpeed;

    // Start is called before the first frame update
    public void StartDialog()
    {
        Init();
        DialogPlay(0, 0);

        thePlayer = FindObjectOfType<PlayerKeyboardController>();
        initSpeed = thePlayer.speed;
        thePlayer.speed = 0;
        thePlayer.transform.localScale = new Vector3(1, 1, 1);

    }

    private void Init()
    {
        dialog = gameObject.GetComponent<RoomDialog>();
        txt1 = dialog.GetPlayertxt();
        txt2 = dialog.GetNPCtxt();
        rulesTxt = dialog.GetRulseDialog();
        rulesNum = 0;
    }

    public void DialogPlay(int count1, int count2)
    {
        count1 = CountTest(count1, 1);
        count2 = CountTest(count2, 2);

        if (rulesTxt[rulesNum] == 3)
        {
            parentTxt1.SetActive(false);
            parentTxt2.SetActive(false);

            thePlayer.speed = initSpeed;
        }
        else
        {
            SetText(count1, count2);
            SwitchSpeaker();
        }

    }
    private void SwitchSpeaker()
    {
        if (rulesTxt[rulesNum] == 1)
        {
            parentTxt1.SetActive(true);
            parentTxt2.SetActive(false);

        }
        else if (rulesTxt[rulesNum] == 2)
        {
            parentTxt2.SetActive(true);
            parentTxt1.SetActive(false);
        }

    }
    private void SetText(int count1, int count2)
    {
        person1txt.GetComponent<Text>().text = txt1[count1];
        person2txt.GetComponent<Text>().text = txt2[count2];
    }
    private int CountTest(int count, int txt) {
        string[] testTXT;
        if (txt == 1)
        {
            testTXT = txt1;
        }
        else
        { testTXT = txt2; }

        if (count>testTXT.Length-1)
        {
            count = testTXT.Length - 1;
        }
        
        return count;
    }

}
