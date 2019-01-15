using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardController : MonoBehaviour {
	private static bool isPlayerExists = false;
	private Rigidbody2D rb2d;
	private Animator animator;
	private bool isMoving;

	public float speed;
	public Vector2 lastMove;

	// Use this for initialization
	void Start() {
		animator = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();

		if (!isPlayerExists) {
			isPlayerExists = true;
			DontDestroyOnLoad(transform.gameObject);
		} else {
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update() {
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");
		//Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
		//transform.Translate(movement * speed * Time.deltaTime);
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.velocity = movement * speed;

		isMoving = moveHorizontal != 0 || moveVertical != 0;
		if (isMoving) {
			lastMove.x = moveHorizontal;
			lastMove.y = moveVertical;
		}

		animator.SetFloat("MoveX", moveHorizontal);
		animator.SetFloat("MoveY", moveVertical);
		animator.SetFloat("LastMoveX", lastMove.x);
		animator.SetFloat("LastMoveY", lastMove.y);
		animator.SetBool("IsMoving", isMoving);
	}


}
