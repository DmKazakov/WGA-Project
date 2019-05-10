using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame2 : MonoBehaviour
{

    public string scene;
    
    // public GameObject dustman2;


    public void OnMouseDown() 
    {
        SceneManager.LoadScene(scene);
      
    }
}