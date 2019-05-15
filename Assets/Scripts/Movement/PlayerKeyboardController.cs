using UnityEngine;

public class PlayerKeyboardController : MovementController {
	private static bool isPlayerExists = false;

	public string statrtPoint;

    public bool openDoor;

	protected override void Start() {
		base.Start();

		if (!isPlayerExists) {
			isPlayerExists = true;
			DontDestroyOnLoad(transform.gameObject);
		} else {
			Destroy(gameObject);
		}
	}

	override protected void Update() {
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		base.MakeMove(movement);

        //openDoor = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            openDoor = true;
        }
	}

    public void Reset() {
        isPlayerExists = false;
    }

}
