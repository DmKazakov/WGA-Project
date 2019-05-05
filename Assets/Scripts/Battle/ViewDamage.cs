using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ViewDamage : MonoBehaviour
{

    private float speed = 2.0f;



    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;

    }

    void Start()
    {
        Destroy(gameObject, 3.0f);
    }
    
    public void toView(int[] info, GameObject target)
    {   //info[0] - dmg
        //info[1] - crit 0 - false, 1 - true, -1 - effect
        int dmg = info[0];
        int crit = info[1];

        GameObject panel = Instantiate(gameObject, target.transform.position, Quaternion.identity);
        panel.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        panel.transform.position = target.transform.position;
        string txt = "";
        if (dmg == 0 && crit != -1)
        {
            panel.GetComponent<Text>().color = Color.yellow;
            txt = "уворот";
            
        }
        else if(dmg<0)
        {
            panel.GetComponent<Text>().color = Color.green;
            dmg = dmg * -1;
            txt = dmg.ToString();
        }
        else if (crit == 1)
        {
            panel.GetComponent<Text>().color = Color.red;
            txt = dmg.ToString();
        }
        else if (dmg>0)
        {
            panel.GetComponent<Text>().color = Color.white;
            txt = dmg.ToString();
        }


        panel.GetComponent<Text>().text = txt;
    }
}
