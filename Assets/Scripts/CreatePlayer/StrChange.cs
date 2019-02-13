using UnityEngine;

public class StrChange : MonoBehaviour {
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
		if (component.freeStatPoints < 1 || component.strength > 9) {
			statsUp.SetActive(false);
		} else {
			statsUp.SetActive(true);
		}

		if (component.strength < 2) {
			statsDown.SetActive(false);
		} else {
			statsDown.SetActive(true);
		}
	}

	public void Up() {
		component.strength += 1;
		component.freeStatPoints -= 1;
	}

	public void Down() {
		component.strength -= 1;
		component.freeStatPoints += 1;
	}
}
