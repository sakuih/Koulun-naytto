using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyController : MonoBehaviour {

	private Transform enemyHolder;
	public float speed;
	public Transform enemy;

	public Text Win;


	public float accelerationValue;
	public float boundaryLeft;
	public float boundaryRight;

	public GameObject enemyshot;
	public Transform enemyshotSpawn;
	public float enemyfireRate;

	void Start () {
		Win.enabled = false;
		InvokeRepeating ("MoveEnemy", 0.1f, 0.3f);
		InvokeRepeating ("Shooting", 1f, 1f);
		enemyHolder = GetComponent<Transform> ();
	}
	void MoveEnemy()
	{
		foreach (Transform enemyColumn2  in enemyHolder) {
			if (enemyColumn2.childCount == 0){
				Destroy (enemyColumn2.gameObject);
			}
			
		}
		enemyHolder.position += Vector3.right * speed;	
		foreach (Transform enemy in enemyHolder) {

			if (enemy.position.x < boundaryLeft || enemy.position.x > boundaryRight) {
				speed = -speed;
				enemyHolder.position += Vector3.down * accelerationValue;
				if (enemy.position.y <= -7) {
					Debug.Log("Peli on päättynyt");
				}
				break;
				
			}
		}


			
		if (enemyHolder.childCount == 1) {
			CancelInvoke ("MoveEnemy");
			InvokeRepeating ("MoveEnemy", 0.5f, 1f);
		}
			if (enemyHolder.childCount == 5) {
				CancelInvoke ("MoveEnemy");
				InvokeRepeating ("MoveEnemy", 0.3f, 0.25f);
			}


		if (enemyHolder.childCount == 0) {
				Debug.Log("Kaikki kuoli");
				Win.enabled = true;
				CancelInvoke();

		}
		

	}
	void Shooting(){
		//if (Time.time > enemynextFire) {
		//	enemynextFire = Time.time + enemyfireRate;'

		Debug.Log ("Shooting");
		int i = Random.Range (0,enemyHolder.childCount -1);
		Transform enemyColumn = enemyHolder.GetChild (i);
		if (enemyColumn.childCount > 0) {
			Transform enemy = enemyColumn.GetChild (enemyColumn.childCount - 1);
			Instantiate (enemyshot, new Vector3  (enemy.position.x,  enemy.position.y-3, 0), enemyHolder.rotation);
			GetComponent<AudioSource>().Play();

		}


		

		//}

	}
}