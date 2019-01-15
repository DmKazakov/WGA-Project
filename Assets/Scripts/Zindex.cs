using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zindex : MonoBehaviour {
	public float parallax;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		transform.position = new Vector3(position.x, position.y, position.y + parallax);
	}
}
