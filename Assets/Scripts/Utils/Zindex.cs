using UnityEngine;

public class Zindex : MonoBehaviour {
	public float parallax;
	
	void Start() {
		Vector3 position = transform.position;
		transform.position = new Vector3(position.x, position.y, position.y + parallax);
	}
}
