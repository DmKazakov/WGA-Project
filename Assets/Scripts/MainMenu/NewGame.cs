using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour {

    public string scene;
    public GameObject player;
    public GameObject dustman;
   // public GameObject dustman2;

	
    public void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
        
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(dustman);
      //  DontDestroyOnLoad(dustman2);
    }
    }

    
    

