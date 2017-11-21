using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooterwithmag : MonoBehaviour {

	public Rigidbody projectile;
	public float speed = 20;
	public float charge;
	public float magazine;
	public Text Textcharge;

	void Update () {
		//charge += 1;
		if(charge == 200)
		{
			magazine++;
			charge -= 100;
		}
		if((charge == 0) && (magazine >=1))
		{
			magazine--;
			charge += 100;
		}

		Textcharge.text = magazine.ToString () + "/" + charge.ToString ();
		if (Input.GetMouseButtonDown(0) && (charge >= 100) && (magazine >=0 ))
		{
			Rigidbody instantiatedProjectile = Instantiate(projectile,
				transform.position,
				transform.rotation)
				as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
			/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
			if((charge >= 100) && (magazine >= 0))
			{
				charge -= 100;
			}
		}
	}
}
