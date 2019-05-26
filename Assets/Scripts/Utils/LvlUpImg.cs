using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlUpImg : MonoBehaviour
{
    GameObject playerAvatar;
    Unit player;
    Unit robot;
    public GameObject window;
    void Start()
    {
        playerAvatar = GameObject.FindGameObjectWithTag("Player");
        player = playerAvatar.GetComponent<Avatar>().squad[0].GetComponent<Unit>();
        robot = playerAvatar.GetComponent<Avatar>().squad[1].GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.perkEmpty<1 && robot.perkEmpty<1)
        {
            window.SetActive(false);
        }
        else
        {

            window.SetActive(true);
        }
    }
}
