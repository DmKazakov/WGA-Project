using UnityEngine;

public class PlayerKeyboardController : MovementController {
	private static bool isPlayerExists = false;

	public string statrtPoint;

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
	}


}
