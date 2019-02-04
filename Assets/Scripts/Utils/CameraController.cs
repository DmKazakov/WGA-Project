using UnityEngine;

public class CameraController : MonoBehaviour {
	private Vector3 targetPos;
	private static bool isCameraExists = false;

	public GameObject followTarget;
	public float speed;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);

		if (!isCameraExists) {
			isCameraExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}
		else {
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
	}
}
