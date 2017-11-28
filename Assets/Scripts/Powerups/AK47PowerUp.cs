using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47PowerUp : PowerUpEffect {

	//Inspector Variables
	public float speedMultiplier = 2.0f;


	new void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{ 
			ammo ak = other.gameObject.GetComponent<ammo>();
			ak.clips += 2;

		}
		//Rigidbody rb = other.transform.root.GetComponent<Rigidbody> ();
		//rb.velocity *= speedMultiplier;
		base.OnTriggerEnter (null);
	}
}
