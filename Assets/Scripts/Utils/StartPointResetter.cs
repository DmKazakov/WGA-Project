using UnityEngine;

public class StartPointResetter : MonoBehaviour {
	private PlayerKeyboardController thePlayer;
	private CameraController theCamera;

	public Vector2 startDirection;

	// Use this for initialization
	void Start() {
		thePlayer = FindObjectOfType<PlayerKeyboardController>();
		thePlayer.transform.position = transform.position;
		thePlayer.lastMove = startDirection;

		theCamera = FindObjectOfType<CameraController>();
		theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
	}
}
