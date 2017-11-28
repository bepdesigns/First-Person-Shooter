using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPowerUp : PowerUpEffect {

	//Inspector Variables
	public float speedMultiplier = 2.0f;


	new void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{ 
			EnemyHealth eh = other.gameObject.GetComponent<EnemyHealth>();
			eh.curHealth = eh.maxHealth;

		}
		//Rigidbody rb = other.transform.root.GetComponent<Rigidbody> ();
		//rb.velocity *= speedMultiplier;
		base.OnTriggerEnter (null);
	}
}
