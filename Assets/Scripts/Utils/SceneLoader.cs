using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour {
	private PlayerKeyboardController thePlayer;

	public string sceneToLoad;
	public string exitPoint;

	private void Start() {
		thePlayer = FindObjectOfType<PlayerKeyboardController>();
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			SceneManager.LoadScene(sceneToLoad);
			thePlayer.statrtPoint = exitPoint;
		}
	}
}
