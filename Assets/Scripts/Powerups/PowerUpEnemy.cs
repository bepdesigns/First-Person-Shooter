﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEnemy : MonoBehaviour {

//	private HealthCasters hc;
	public float invincibleTime = 1.0f;
	private MeshRenderer Mrender;

	void Start()
	{
		StartCoroutine(AddClip());
		Mrender = GetComponent<MeshRenderer> ();
	}


	public void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "Enemy")
		{ 
			EnemyHealth eh = other.gameObject.GetComponent<EnemyHealth>();
			eh.curHealth += eh.maxHealth;
			StartCoroutine(AddClip());
			//Destroy(gameObject);

			//GetComponent<MeshRenderer>().enabled = false;
			//GetComponent<BoxCollider>().enabled = false;
		}
	}

	public IEnumerator AddClip () 
	{
		//HealthCasters hc = gameObject.GetComponent<HealthCasters>();
		//hc.enabled = false;
		StartCoroutine(Flicker());
		//invincibleTime -= Time.deltaTime;
		//Debug.Log ("Health Disabled " + hc.currentHealth);
		yield return new WaitForSeconds(invincibleTime);
		//hc.enabled = true;
		//Debug.Log ("Health Enabled " + hc.currentHealth);


	}

	private IEnumerator Flicker()
	{
		Mrender.enabled = false;
		yield return new WaitForSeconds(.1f);
		Mrender.enabled = true;
		yield return new WaitForSeconds(.1f);
	}
}
