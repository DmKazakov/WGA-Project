using UnityEngine;

public class VitChange : MonoBehaviour {
	public GameObject player;
	public GameObject statsUp;
	public GameObject statsDown;
	Unit component;

	// Use this for initialization
	void Start() {
		component = player.GetComponent<Unit>();
	}

	// Update is called once per frame
	void Update() {
		if (component.freeStatPoints < 1 || component.vitality > 9) {
			statsUp.SetActive(false);
		} else {
			statsUp.SetActive(true);
		}

		if (component.vitality < 2) {
			statsDown.SetActive(false);
		} else {
			statsDown.SetActive(true);
		}
	}

	public void Up() {
		component.vitality += 1;
		component.freeStatPoints -= 1;
	}

	public void Down() {
		component.vitality -= 1;
		component.freeStatPoints += 1;
	}
}
