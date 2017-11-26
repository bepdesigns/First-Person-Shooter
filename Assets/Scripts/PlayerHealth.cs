using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth = 100; 
	public int curHealth; 
	private Vector3 spawn;
	public Text NbLifeText;
	public Transform GameOvermenuUI;

	public GameObject deathParticles;

	CursorLockMode wantedMode;

	// Use this for initialization 
	void Start () { 
		curHealth = maxHealth;
		spawn = new Vector3(-15, 2, -129);
	} 

	// Update is called once per frame 
	void Update () { 
		AdjustCurrentHealth(0); 

		NbLifeText.text = "" + curHealth.ToString ();
	} 

	// Apply requested cursor state
	void SetCursorState()
	{
		Cursor.lockState = wantedMode;
		// Hide cursor when locking
		Cursor.visible = (CursorLockMode.Locked != wantedMode);
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
		Time.timeScale = 0;
		GameOvermenuUI.gameObject.SetActive (true);
		Cursor.lockState = wantedMode = CursorLockMode.None;
		Instantiate (deathParticles, transform.position, Quaternion.Euler (1000, 0, 0));
		transform.position = spawn;
		curHealth = maxHealth;
	}
}
