using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesGiveDamage : MonoBehaviour 
{

	//EnemyHealth eh;

	void Start()
	{
		//eh = GetComponent<EnemyHealth> ();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") 
		{
			PlayerHealth ph = col.gameObject.GetComponent<PlayerHealth>();

			ph.curHealth -= 10;
			RenderSettings.ambientLight = Color.red;
			
		}
		Destroy (this.gameObject);
	}
}
