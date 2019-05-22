using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour
{

    public string scene;
    public GameObject player;
    public GameObject dustman;
    // public GameObject dustman2;


    public void OnMouse()
    {





        SceneManager.LoadScene(scene);

        player.SetActive(true);

        DontDestroyOnLoad(player);
        DontDestroyOnLoad(dustman);
    }
}




