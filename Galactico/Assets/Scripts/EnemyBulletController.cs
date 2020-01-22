using UnityEngine;
using System.Collections;

public class EnemyBulletController : MonoBehaviour {
private Transform EnemyBullet;
public float enemybulletspeed;
private Rigidbody2D rb;
	
	// Use this for initialization
	
	
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		EnemyBullet = GetComponent<Transform> ();
		rb.AddForce(transform.up * enemybulletspeed);
	}
	
	void FixedUpdate(){
		
		if (EnemyBullet.position.y < -10)
			Destroy (gameObject);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		Destroy (gameObject);
		
		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			GameOver.IsPlayerDead = true;
		}
	}
}