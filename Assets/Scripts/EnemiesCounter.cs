using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesCounter : MonoBehaviour {
	// Use this for initialization


	public Text text;
	public Text wintext;

	int enemiesLeft = 0;
	public GameObject blocker03;
	public GameObject blocker04;
	public GameObject blocker05;

	public Transform menuUI;

	bool killedAllEnemies = false;

	void Start () {
		enemiesLeft = 10; // or whatever;
		wintext.enabled = false;

	}

	// Update is called once per frame
	void Update () {

		text.text = "" + enemiesLeft;
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		enemiesLeft = enemies.Length;

			
		if(enemiesLeft >= 150)
		{
			Destroy (blocker03, 3);
			Destroy (blocker04, 4);
			Destroy (blocker05, 5);

		}
		if(enemiesLeft == 0)
		{
			endGame();
			wintext.enabled = true;
			Time.timeScale = 0;
			menuUI.gameObject.SetActive (true);
		}
	}

	void endGame()
	{
		killedAllEnemies = true;
	}

	/*void OnGUI()
	{
		if(killedAllEnemies)
		{
			GUI.Label(new Rect (0,0,200,20),"all gone");
		}
		else
		{
			GUI.Label(new Rect (0,0,200,20),"Enemies Remaining : " + enemiesLeft);
		}
	}*/
}
