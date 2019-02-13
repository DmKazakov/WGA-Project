using System;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour {
	public Button strUp;
	public Button strDown;
	public Button vitUp;
	public Button vitDown;
	public Button agilUp;
	public Button agilDown;
	public GameObject player;

	private Unit playerStats;

	// Start is called before the first frame update
	void Start() {
		playerStats = player.GetComponent<Unit>();

		strUp.onClick.AddListener(() => playerStats.strength++);
		strDown.onClick.AddListener(() => playerStats.strength--);
		vitUp.onClick.AddListener(() => playerStats.vitality++);
		vitDown.onClick.AddListener(() => playerStats.vitality--);
		agilUp.onClick.AddListener(() => playerStats.agility++);
		agilDown.onClick.AddListener(() => playerStats.agility--);

		strUp.onClick.AddListener(RemoveStatPoint);
		strDown.onClick.AddListener(AddStatPoint);
		vitUp.onClick.AddListener(RemoveStatPoint);
		vitDown.onClick.AddListener(AddStatPoint);
		agilUp.onClick.AddListener(RemoveStatPoint);
		agilDown.onClick.AddListener(AddStatPoint);

		playerStats.Init();
		ValidateButtonsState();
	}

	private void AddStatPoint() {
		playerStats.freeStatPoints++;
		ValidateButtonsState();
	}

	private void RemoveStatPoint() {
		playerStats.freeStatPoints--;
		ValidateButtonsState();
	}

	private void ValidateButtonsState() {
		playerStats.Recalc();
		if (playerStats.freeStatPoints > 0) {
			ChangeUpButtonsState(true);
		}

		if (playerStats.agility == 1) {
			agilDown.interactable = false;
		} else {
			agilDown.interactable = true;
		}
		if (playerStats.agility == 10) {
			agilUp.interactable = false;
		}
		if (playerStats.strength == 1) {
			strDown.interactable = false;
		} else {
			strDown.interactable = true;
		}
		if (playerStats.strength == 10) {
			strUp.interactable = false;
		}
		if (playerStats.vitality == 1) {
			vitDown.interactable = false;
		} else {
			vitDown.interactable = true;
		}
		if (playerStats.vitality == 10) {
			vitUp.interactable = false;
		}

		if (playerStats.freeStatPoints == 0) {
			ChangeUpButtonsState(false);
		}
	}

	private void ChangeUpButtonsState(bool isInteractable) {
		agilUp.interactable = isInteractable;
		vitUp.interactable = isInteractable;
		strUp.interactable = isInteractable;
	}
}
