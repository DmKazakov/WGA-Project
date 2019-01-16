using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementController : MonoBehaviour {
	private Rigidbody2D rb2d;
	private Animator animator;
	private bool isMoving;

	public float speed;
	public Vector2 lastMove;

	// Use this for initialization
	protected virtual void Start() {
		animator = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	protected abstract void Update();

	protected void MakeMove(Vector2 movement) {
		rb2d.velocity = movement * speed;

		isMoving = movement.x != 0 || movement.y != 0;
		if (isMoving)
		{
			lastMove.x = movement.x;
			lastMove.y = movement.y;
		}

		animator.SetFloat("MoveX", movement.x);
		animator.SetFloat("MoveY", movement.y);
		animator.SetFloat("LastMoveX", lastMove.x);
		animator.SetFloat("LastMoveY", lastMove.y);
		animator.SetBool("IsMoving", isMoving);
	}
}
