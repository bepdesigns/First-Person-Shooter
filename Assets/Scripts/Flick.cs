using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flick : MonoBehaviour {

//	private HealthCasters hc;
	public float invincibleTime = 1.0f;
	private MeshRenderer Mrender;

	void Start()
	{
		StartCoroutine(Flicker());
		Mrender = GetComponent<MeshRenderer> ();
	}
		
	private IEnumerator Flicker()
	{
		Mrender.enabled = false;
		yield return new WaitForSeconds(.1f);
		Mrender.enabled = true;
		yield return new WaitForSeconds(.1f);
	}
}
