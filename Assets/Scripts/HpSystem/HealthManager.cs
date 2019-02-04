using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthManager : MonoBehaviour {
	public Slider slider;
	public int maxHP;

	private int currentHp;

	// Use this for initialization
	void Start () {
		currentHp = maxHP;
		slider.maxValue = maxHP;
		slider.minValue = 0;
		slider.value = currentHp;
	}
	
	public void ChangeHP(int change) {
		currentHp = Math.Max(currentHp + change, 0);
		slider.value = currentHp;

		if (currentHp <= 0) {
			//do sth
		}
	}

	public void ChangeMaxHP(int change) {
		maxHP += change;
		slider.maxValue = maxHP;
	}
}
