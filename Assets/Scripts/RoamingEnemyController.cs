using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamingEnemyController : MovementController {
	public float timeToMove;
	public float timeBeteweenMovements;

	private Vector2 moveDirection;
	private float timeToMoveCounter;
	private float timeBeteweenMovementsCounter;

	protected override void Start() {
		base.Start();
		timeToMoveCounter = Random.Range(timeToMove / 1.5f, timeToMove * 1.5f);
		timeBeteweenMovementsCounter = Random.Range(timeBeteweenMovementsCounter / 1.5f, timeBeteweenMovementsCounter * 1.5f);
	}

	protected override void Update() {
		if(IsMoving()) {
			timeToMoveCounter -= Time.deltaTime;
			MakeMove(moveDirection);
			if (timeToMoveCounter < 0) {
				timeBeteweenMovementsCounter = timeBeteweenMovements;
			}
		} else {
			timeBeteweenMovementsCounter -= Time.deltaTime;
			MakeMove(Vector2.zero);
			if (timeBeteweenMovementsCounter < 0) {
				timeToMoveCounter = timeToMove;
				moveDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
			}
		}
	}

	private bool IsMoving() {
		return timeBeteweenMovementsCounter <= 0;
	}
}
