using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ViewDamage : MonoBehaviour
{
    public GameObject obj;
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
    public void Init(int dmg)
    {
      
        gameObject.GetComponent<Text>().text = dmg.ToString();
    }
}
