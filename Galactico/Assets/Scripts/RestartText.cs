using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartText : MonoBehaviour {

	public static Text Restart;

	void Start () {
		Restart = GetComponent<Text> ();
		Restart.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Score.playerScore = 0;
			GameOver.IsPlayerDead = false;
			Time.timeScale = 1;
			Application.LoadLevel (Application.loadedLevel);
			Score.scoring = 0;
		}
	}
}