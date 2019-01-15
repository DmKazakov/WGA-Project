using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour {
	public string sceneToLoad;

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			SceneManager.LoadScene(sceneToLoad);
		}
	}
}
