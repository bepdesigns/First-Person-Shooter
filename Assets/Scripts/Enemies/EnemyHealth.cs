using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public int maxHealth = 100; 
	public int curHealth; 
	public static int scoreValue = 1; 
	public static int kills = 1;

	public bool drop;
	public GameObject theDrop;
	public GameObject deathParticles;
	public Text NbLifeText;

	ScoreManager sm;


	//UnityEngine.AI.NavMeshAgent agent;


	// Use this for initialization 
	void Start () 
	{ 
		curHealth = maxHealth;
		//scoreValue = 0; 
		//kills = 0;
		//UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		sm = GameObject.Find("GameManager").GetComponent<ScoreManager>();

		//foreach (GameObject enemy in theDrop)
		//{
		//	print(enemy);
			//theDrop = new GameObject[2];

		//}
	} 

	// Update is called once per frame 
	void Update () { 
		AdjustCurrentHealth(0);
		NbLifeText.text = "" + curHealth.ToString ();

		if(curHealth <= 0)
		{
			RenderSettings.ambientLight = Color.red;
			Death ();
		}
	} 




	public void AdjustCurrentHealth(int adj) { 
		curHealth += adj; 

		if (curHealth < 0)
			curHealth = 0; 

		if (curHealth > maxHealth)
			curHealth = maxHealth; 

		if (maxHealth < 1)
			maxHealth = 1; 

	}


public void Death ()
	{
		// Increase the score by the enemy's score value.
		ScoreManager.score += scoreValue;
		ScoreManager.kills += kills;
		drop = true;
		if(drop) Instantiate (theDrop,transform.position, transform.rotation);
		Instantiate (deathParticles, transform.position, Quaternion.Euler (1000, 0, 0));

	// The enemy is dead.
		Destroy(this.gameObject,2f);
	}
}
