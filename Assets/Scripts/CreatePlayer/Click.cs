using UnityEngine;

public class Click : MonoBehaviour {
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void click() {
        player.GetComponent<Unit>().strength += 1;
    }
}
