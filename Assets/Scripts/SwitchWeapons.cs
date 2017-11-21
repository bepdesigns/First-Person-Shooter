using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour 

{
	public GameObject weapon01;
	public GameObject weapon02;
	public GameObject weapon03;

	// Use this for initialization
	void Start () 
	{
		weapon02.SetActive (false);
		weapon03.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 

	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			WeaponSwitcher ();
		}
	}
	void WeaponSwitcher()
	{
		if (weapon01.activeSelf) {
			weapon01.SetActive (false);
			weapon02.SetActive (true);
			weapon03.SetActive (false);

		} else if(weapon02.activeSelf){
			weapon01.SetActive (false);
			weapon02.SetActive (false);
			weapon03.SetActive (true);
		}else  {
		weapon01.SetActive (true);
		weapon02.SetActive (false);
		weapon03.SetActive (false);
	}
}

}
