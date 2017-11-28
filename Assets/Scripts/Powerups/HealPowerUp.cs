using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPowerUp : PowerUpEffect {

	//Inspector Variables
	public float speedMultiplier = 2.0f;


	new void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{ 
			PlayerHealth ph = other.gameObject.GetComponent<PlayerHealth>();
			ph.curHealth += 20;

		}
		//Rigidbody rb = other.transform.root.GetComponent<Rigidbody> ();
		//rb.velocity *= speedMultiplier;
		base.OnTriggerEnter (null);
	}
}
