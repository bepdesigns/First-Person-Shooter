using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Transform menuUI;
	private Transform Camera;
	//public Text gameOverText;
	public Transform unpaused;
	//public Transform Resume;

	// Use this for initialization
	void Start () { 

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			UnPause ();
			ExitGame ();
			Pause ();
			Restart ("0");
			Time.timeScale = 0;
		} else 
		{
			Time.timeScale = 1;
		}
	}
	public void UnPause()
	{
		if (menuUI.gameObject.activeInHierarchy == false) 
		{
			menuUI.gameObject.SetActive (true);
			unpaused.gameObject.SetActive (true);
			//Resume.gameObject.SetActive (true);
			Time.timeScale = 0;

		} 
		else 
		{
			menuUI.gameObject.SetActive (false);
			unpaused.gameObject.SetActive (false);
			//Resume.gameObject.SetActive (false);
			Time.timeScale = 1;
			//Camera.GetComponent<CharacterController> ().enabled = true;


		}
	}
	public void ExitGame()
	{
		Application.Quit ();
	}
	public void Pause()
	{
		Time.timeScale = 0;
	}
	public void Restart(string scene)
	{
		SceneManager.LoadScene(scene);
		Time.timeScale = 1;
	}
}
