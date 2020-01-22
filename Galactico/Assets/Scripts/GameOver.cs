using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public static bool IsPlayerDead = false;
	public static bool  IsBaseDead  = false;
	private Text gameOver;

	void Start () {
		gameOver = GetComponent<Text> ();
		gameOver.enabled = false;
	}

	void Update () {
		if (IsPlayerDead) {
			Time.timeScale = 0;
			gameOver.enabled = true;
			RestartText.Restart.enabled = true;
		}
		if (IsBaseDead) {
			Time.timeScale = 0;
			gameOver.enabled = true;
			RestartText.Restart.enabled = true;

		}
	}
}