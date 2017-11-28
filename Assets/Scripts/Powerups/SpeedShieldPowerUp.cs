using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedShieldPowerUp : PowerUpEffect {

	//Inspector Variables
	public float speedMultiplier = 2.0f;



	new void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") { 
			PlayerHealth ph = other.gameObject.GetComponent<PlayerHealth> ();
			ph.maxHealth += 50;
			ph.maxHealth = 500;

		}

		if (other.gameObject.tag == "Player")
		{ 
			PlayerMove pm = other.gameObject.GetComponent<PlayerMove>();
			pm.walkSpeed += 3;


		}
		//Rigidbody rb = other.transform.root.GetComponent<Rigidbody> ();
		//rb.velocity *= speedMultiplier;
		base.OnTriggerEnter (null);

	}
}
