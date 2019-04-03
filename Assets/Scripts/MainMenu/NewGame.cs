using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour {

    public string scene;

	
    public void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
    }

    
    
}
