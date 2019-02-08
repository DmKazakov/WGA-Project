using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void OnMouseDown()
    {
        SceneManager.LoadScene("CreatePlayer");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
