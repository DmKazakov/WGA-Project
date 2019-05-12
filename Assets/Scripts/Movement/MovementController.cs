using UnityEngine;

public abstract class MovementController : MonoBehaviour {
	private Rigidbody2D rb2d;
	private Animator animator;
	private bool isMoving;
    private Vector3 initialScale;

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

        initialScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}

	protected void MakeMove(Vector2 movement) {
		rb2d.velocity = movement.normalized * speed;
		Zindex();

		isMoving = rb2d.velocity.x != 0 || rb2d.velocity.y != 0;
		if (isMoving) {
			lastMove.x = movement.x;
			lastMove.y = movement.y;
		}

        //check direction
        if (rb2d.velocity.x < 0)
        {
            transform.localScale = new Vector3(-initialScale.x, initialScale.y, initialScale.z);
        }
        else if (rb2d.velocity.x > 0)
        {
            transform.localScale = new Vector3(initialScale.x, initialScale.y, initialScale.z);
        }

        if (rb2d.velocity.x != 0)
            animator.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        else
            animator.SetFloat("speed", Mathf.Abs(rb2d.velocity.y));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("dash");
        }
    }

	private void Zindex() {
		Vector3 position = transform.position;
		transform.position = new Vector3(position.x, position.y, 0/*position.y + parallax*/);
	}
}
