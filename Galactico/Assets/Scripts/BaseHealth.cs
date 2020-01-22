using UnityEngine;
using System.Collections;

public class BaseHealth : MonoBehaviour {

	public int health = 3;
	public int count  = 0;
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col)
	{

		health =  health -1;
		Debug.Log (health);
		Debug.Log ("osui");
		if (health == 0) {
			Destroy (gameObject);
			count++;
			Debug.Log(count);
		}
		/*if (count == 3) {
			GameOver.IsBaseDead = true;

		}
		*/
	}
}
