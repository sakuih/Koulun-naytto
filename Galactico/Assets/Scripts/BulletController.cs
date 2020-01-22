using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	private Transform bullet;
	public float speed;
	private Rigidbody2D rb;

	// Use this for initialization

	
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		bullet = GetComponent<Transform> ();
		rb.AddForce(transform.up * speed);
	}

	void FixedUpdate(){

		if (bullet.position.y >= 10)
			Destroy (gameObject);
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		Destroy (gameObject);

		if (col.gameObject.tag == "Enemies") {
			Destroy (col.gameObject);
			Score.scoring  += 10;
		}
	}
}
