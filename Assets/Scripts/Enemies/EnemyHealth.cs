using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int maxHealth = 100; 
	public int curHealth; 
	public int scoreValue = 1; 

	public bool drop;
	public GameObject[] theDrop;
	public GameObject deathParticles;


	// Use this for initialization 
	void Start () 
	{ 
		curHealth = maxHealth;

		foreach (GameObject enemy in theDrop)
		{
			print(enemy);
			theDrop = new GameObject[2];

		}
	} 

	// Update is called once per frame 
	void Update () { 
		AdjustCurrentHealth(0); 
	} 




	public void AdjustCurrentHealth(int adj) { 
		curHealth += adj; 

		if (curHealth < 0)
			curHealth = 0; 

		if (curHealth > maxHealth)
			curHealth = maxHealth; 

		if (maxHealth < 1)
			maxHealth = 1;    
		
		if(curHealth <= 0)
		{
			Death ();
		}

	}


public void Death ()
	{
		// Increase the score by the enemy's score value.
		ScoreManager.score += scoreValue;
		drop = true;
		if(drop) Instantiate (theDrop[0],transform.position, transform.rotation);
		Instantiate (deathParticles, transform.position, Quaternion.Euler (1000, 0, 0));

	// The enemy is dead.
		Destroy(this.gameObject,2f);
	}
}
