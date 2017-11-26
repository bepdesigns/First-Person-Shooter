using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth = 100; 
	public int curHealth; 
	private Vector3 spawn;
	public Text NbLifeText;

	public GameObject deathParticles;

	// Use this for initialization 
	void Start () { 
		curHealth = maxHealth;
		spawn = new Vector3(11, 1, 20);
	} 

	// Update is called once per frame 
	void Update () { 
		AdjustCurrentHealth(0); 

		NbLifeText.text = "" + curHealth.ToString ();
	} 




	public void AdjustCurrentHealth(int adj) { 
		curHealth += adj; 

		if(curHealth < 0) 
			curHealth = 0; 

		if (curHealth > maxHealth) 
			curHealth  = maxHealth; 

		if (maxHealth < 1) 
			maxHealth = 1;    

		if(curHealth <= 0)
		{
			Death ();
			RenderSettings.ambientLight = Color.red;
		}

	}


	void Death ()
	{
		// The enemy is dead.
		Instantiate (deathParticles, transform.position, Quaternion.Euler (1000, 0, 0));
		transform.position = spawn;
		curHealth = maxHealth;
	}
}
