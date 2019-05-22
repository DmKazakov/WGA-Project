using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{

    public string scene;
    public GameObject player;
    public GameObject dustman;
    public GameObject message;
    // public GameObject dustman2;


    public void OnMouse()
    {
        Unit unit = player.GetComponent<Avatar>().squad[0].GetComponent<Unit>();
        string txt = "";
        if (unit.currentSkills[2] == null)
        {
            txt = "Вы не выбрали умение, продолжить?";
            MessageON(txt);
        }
        else if (unit.freeStatPoints>0)
        {
            txt = "У вас остались не распределенные очки характеристик, продолжить?";
            MessageON(txt);
        }
        else
        {
            StartGame();
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(scene);

        player.SetActive(true);

        DontDestroyOnLoad(player);
        DontDestroyOnLoad(dustman);
    }

    private void MessageON(string txt)
    {
        message.GetComponent<Text>().text = txt;
        message.transform.parent.transform.gameObject.SetActive(true);
    }
}





