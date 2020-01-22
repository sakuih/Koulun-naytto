using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

	public static int playerScore = 0;
	private Text scoreText;
	public static int scoring = 0;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "SCORE: " + scoring;
	}
}
