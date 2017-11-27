using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

	public GameObject spawnPoint;
	public GameObject ExplosionPrefab;
	public Rigidbody projectilePrefab;

	private float FireRate = 1.0f;
	private float NextFire;

	public AudioClip shotSound;
	public AudioClip reloadSound;
	public AudioClip clickSound; // optional "no bullets" click sound
	public int clips = 2; // how many clips you have
	public int bulletsPerClip = 20; // how many bullets per clip
	public int bullets; // start with a brand new clip in the gun
	public float reloadTime = 1.0f; // reload time in seconds

	public Text bulletText; 

	// Use this for initialization
	void Start () 
	{
		//bullets = bulletsPerClip;
		bulletText.enabled = false;

	}

	// Update is called once per frame
	void Update () {
		bulletText.text = "Kills: " + bullets;

		if(Input.GetButtonDown("Fire1")&& Time.time >= NextFire)
		{
			bulletText.enabled = true;
			NextFire = Time.time + FireRate;

		
				if (bullets > 0){ // and you have bullets...
					Shooter( ); // shoot

				} 
			// but if gun empty... 
			else if (clips > 0){ // and still have ammo clips...
						StartCoroutine(Reload()); // start reload routine
				Debug.Log("go");
					}
			// no bullets, no clips:
			else if  (clickSound){ // play a click sound, if desired
							//audio.PlayOneShot(clickSound);
						}
			}

		}

	public void Shooter ( )
	{
		bullets -= 1; // got one clip, decrement clip count:
		Rigidbody hitPlayer;
		hitPlayer = Instantiate(projectilePrefab, spawnPoint.transform.position, spawnPoint.transform.rotation) as Rigidbody;
		hitPlayer.velocity = transform.TransformDirection(Vector3.forward * 100);
		//            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );

	}
	private bool reloading = false; // is true while reloading, false otherwise

	IEnumerator Reload(){
		// abort other Reload calls if already reloading:
		if (!reloading) yield return null;

		reloading = true; // signals that is currently reloading
		clips -= 1; // got one clip, decrement clip count:
		//audio.PlayOneShot(reloadSound); // play the reload sound
		yield  return new WaitForSeconds(reloadTime); // wait the reload time
		bullets = bulletsPerClip; // now the bullets are available
		reloading = false; // reloading finished
	}
}
