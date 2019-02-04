using UnityEngine;

public class EnemyController : MovementController {
	public float timeToMove;
	public float timeBeteweenMovements;
	public float chaseDistance;
	public float speedUp;

	private MovementMode movementMode;
	private bool isSpeededUp = false;

	protected override void Start() {
		Init();
		movementMode = new RoamingMode(this);
	}

	protected override void Update() {
		Vector2? movement = movementMode.getNextMove();
		if (movement == null) {
			movementMode = new RoamingMode(this);
			movement = movementMode.getNextMove();
		}
		MakeMove((Vector2)movement);
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			print("See you!\n");
			movementMode = new ChaseMode(this, collision.gameObject);
			if (!isSpeededUp) {
				speed += speedUp;
				isSpeededUp = true;
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Untagged") {
			if (movementMode is RoamingMode) {
				((RoamingMode)movementMode).changeDirection();
			} else {
				movementMode = new RoamingMode(this);
			}

			if (isSpeededUp) {
				speed -= speedUp;
				isSpeededUp = false;
			}
		} else if (collision.gameObject.tag == "Player") {
			print("Catch you!\n");
		}
	}

	private class RoamingMode : MovementMode {
		private EnemyController controller;
		private float timeToMoveCounter;
		private float timeBeteweenMovementsCounter;
		private Vector2 moveDirection;

		public RoamingMode(EnemyController controller) {
			this.controller = controller;
			timeToMoveCounter = Random.Range(controller.timeToMove / 1.5f, controller.timeToMove * 1.5f);
			timeBeteweenMovementsCounter = Random.Range(timeBeteweenMovementsCounter / 1.5f, timeBeteweenMovementsCounter * 1.5f);
		}

		public Vector2? getNextMove() {
			if (IsMoving()) {
				timeToMoveCounter -= Time.deltaTime;
				if (timeToMoveCounter < 0) {
					timeBeteweenMovementsCounter = controller.timeBeteweenMovements;
				}
				return moveDirection;
			} else {
				timeBeteweenMovementsCounter -= Time.deltaTime;
				if (timeBeteweenMovementsCounter < 0) {
					timeToMoveCounter = controller.timeToMove;
					changeDirection();
				}
				return Vector2.zero;
			}
		}

		public void changeDirection() {
			moveDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
		}

		private bool IsMoving() {
			return timeBeteweenMovementsCounter <= 0;
		}
	}

	private class ChaseMode : MovementMode {
		private GameObject target;
		private EnemyController controller;

		public ChaseMode(EnemyController controller, GameObject target) {
			this.target = target;
			this.controller = controller;
		}

		public Vector2? getNextMove() {
			if (Vector2.Distance(currentPosition(), targetPosition()) > controller.chaseDistance) {
				print("Lost you!");
				return null;
			}
			return target.transform.position - controller.transform.position;
		}

		private Vector2 currentPosition() {
			return controller.transform.position;
		}

		private Vector2 targetPosition() {
			return target.transform.position;
		}
	}
}
