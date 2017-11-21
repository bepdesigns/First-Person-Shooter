using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

	public GameObject bomb;
	public float velocity = 7f;
	public float damage = 35f;
	public float radius = 3.0f;
	public float power = 10.0F;
	public float upforce = 1.0f;


	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	//IEnumerator Start () {
		//yield return new WaitForSeconds (15f);
		//Destroy(gameObject);
	//}

	void FixedUpdate () {

		if (bomb == enabled) 
		{
			Invoke( "Detonate" ,5);
		}

		rb.velocity  = transform.TransformDirection(Vector3.forward * 100);
	}

	void OnCollisionEnter (Collision info) 
	{
		Detonate ();
		Destroy (bomb, 6);
	}
	void Detonate()
	{
		Vector3 explosionPos = bomb.transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders)
		{
			Rigidbody rb = hit.GetComponent<Rigidbody>();

			if (rb != null)
				rb.AddExplosionForce(power, explosionPos, radius, upforce, ForceMode.Impulse);
			//Instantiate (deathParticles, transform.position, Quaternion.Euler (1000, 0, 0));
		}
	}
		
}
