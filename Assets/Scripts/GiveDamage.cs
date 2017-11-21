using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : MonoBehaviour 
{

	//EnemyHealth eh;

	void Start()
	{
		//eh = GetComponent<EnemyHealth> ();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
			EnemyHealth eh = col.gameObject.GetComponent<EnemyHealth>();

			eh.curHealth -= 10;
			
		}
		Destroy (this.gameObject, 3);
	}
}
