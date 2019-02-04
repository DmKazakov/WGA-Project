using UnityEngine;

public abstract class MovementController : MonoBehaviour {
	private Rigidbody2D rb2d;
	private Animator animator;
	private bool isMoving;

	public float parallax;
	public float speed;
	public Vector2 lastMove;

	// Use this for initialization
	protected virtual void Start() {
		Init();
	}

	// Update is called once per frame
	protected abstract void Update();

	protected void Init() {
		animator = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}

	protected void MakeMove(Vector2 movement) {
		rb2d.velocity = movement.normalized * speed;
		Zindex();

		isMoving = rb2d.velocity.x != 0 || rb2d.velocity.y != 0;
		if (isMoving) {
			lastMove.x = movement.x;
			lastMove.y = movement.y;
		}

		animator.SetFloat("MoveX", rb2d.velocity.x);
		animator.SetFloat("MoveY", rb2d.velocity.y);
		animator.SetFloat("LastMoveX", lastMove.x);
		animator.SetFloat("LastMoveY", lastMove.y);
		animator.SetBool("IsMoving", isMoving);
	}

	private void Zindex() {
		Vector3 position = transform.position;
		transform.position = new Vector3(position.x, position.y, position.y + parallax);
	}
}
