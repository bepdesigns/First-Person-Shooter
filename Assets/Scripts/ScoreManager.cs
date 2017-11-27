using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score; // The player's score.
	public static int kills;
	public static int killsCount;


	public Text text;                      // Reference to the Text component.
	public Text Killstext; 


	void Start ()
	{
		// Set up the reference.
		//text = GetComponent <Text> ();

		// Reset the score.
		score = 0;
		kills = 0;
	}


	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score;
		Killstext.text = "Kills: " + kills;
	}
}
