using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

	public GameObject spawnPoint;
	public Rigidbody rocketPrefab;

	private float FireRate = 2.0f;
	private float NextFire;


	void Update () 
	{
		if(Input.GetButtonDown("Fire1")&& Time.time >= NextFire)
		{
			NextFire = Time.time + FireRate;
			rocketPrefab = Instantiate( rocketPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation) as Rigidbody;
		}
	}
}
