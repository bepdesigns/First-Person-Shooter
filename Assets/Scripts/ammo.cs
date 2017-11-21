using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo : MonoBehaviour {

	public Text text; 

	public float ammoInClip = 15f;
	public float clipCapacity = 15f;
	public float clips = 5;


	public void Update()
	{
		text.text = "Clips: " + clips;
	}
}
