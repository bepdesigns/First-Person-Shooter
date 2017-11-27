using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooting : MonoBehaviour {

	public Transform player;
	public float range = 20.0f;
	public float bulletImpulse= 20.0f;

	private bool onRange= false;

	public Rigidbody projectile;
	public GameObject spawnPoint;

	private float NextFire;
	private float FireRate = 1.0f;

	void Start(){
		float rand = Random.Range (1.0f, 2.0f);
		InvokeRepeating("Shoot", 2, rand);
	}

	void Shoot(){

		if (onRange && Time.time >= NextFire){

			//NextFire = Time.time + FireRate;
			Rigidbody bullet = (Rigidbody)Instantiate(projectile, spawnPoint.transform.position + transform.forward, spawnPoint.transform.rotation);
			bullet.AddForce(transform.forward*bulletImpulse, ForceMode.Impulse);

			Destroy (bullet.gameObject, 2);
		}


	}

	void Update() {

		onRange = Vector3.Distance(transform.position, player.position)<range;

		if (onRange)
			transform.LookAt(player);
		Shoot ();
	}
}
