using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47 : MonoBehaviour {
	public GameObject bullet_prefab;
	public float bulletImpulse = 200f;
	public float cooldown = 0.1f;
	float coolDownRemaining = 0; 
	private float ammoInClip;
	private float clipCapacity;
	public float clips;
	public ammo _ammo;

	// Update is called once per frame

	void Start(){
		_ammo = GetComponentInParent<ammo> ();

	}
	void Update () {
		coolDownRemaining -= Time.deltaTime;

		if( Input.GetMouseButton(0) && coolDownRemaining <= 0 && _ammo.ammoInClip >= 0) {
			_ammo.text.enabled = true;
			coolDownRemaining = cooldown;
			Camera cam = Camera.main;
			GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
			thebullet.GetComponent<Rigidbody>().AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
			_ammo.ammoInClip -= 1;

		
		}
		else if (Input.GetMouseButton (0) && _ammo.ammoInClip <= 0 && _ammo.clips >= 1) {
			Debug.Log("Reloaded", gameObject);
			_ammo.clips -= 1;
			_ammo.ammoInClip += (_ammo.clipCapacity);
		}
	}
}
