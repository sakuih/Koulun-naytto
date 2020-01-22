using UnityEngine;
using System.Collections;

public class enemyLife : MonoBehaviour {
	public static int hp = 1;

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D ()
	{
		Destroy (gameObject);
	}

}
