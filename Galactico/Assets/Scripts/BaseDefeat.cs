using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseDefeat : MonoBehaviour {

	private Transform playerBase;

	void Start () {
		playerBase = GetComponent<Transform> ();
	}
	void Update () {
		if (playerBase.childCount == 0)
			GameOver.IsPlayerDead = true;
}
}