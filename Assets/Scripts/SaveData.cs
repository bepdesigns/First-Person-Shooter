using UnityEngine;    // For Debug.Log, etc.

using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System;
using System.Runtime.Serialization;
using System.Reflection;

// === This is the info container class ===
[Serializable ()]
public class SaveData : MonoBehaviour {




	public void Start()
	{
		
	}

	public void Save()
	{
		BinaryFormatter binary = new BinaryFormatter ();
		FileStream fStream = File.Create (Application.persistentDataPath + "saveFile.Benson");

		SaveManager Saver = new SaveManager ();
		Saver.killcount = ScoreManager.score;

		binary.Serialize (fStream, Saver);
		fStream.Close ();
	}

	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/saveFile.Benson")) 
		{
			BinaryFormatter binary = new BinaryFormatter ();
			FileStream fStream = File.Open (Application.persistentDataPath + "saveFile.Benson", FileMode.Open);
			SaveManager saver = (SaveManager)binary.Deserialize (fStream);
			fStream.Close ();

			ScoreManager.score = saver.killcount;
		}
	}

	public void Delete()
	{
		if(File.Exists(Application.persistentDataPath + "/saveFile.Benson"))
		{
			File.Delete(Application.persistentDataPath + "/saveFile.Benson");
		}
	} 
}

	[Serializable]
	class SaveManager
	{
		public int killcount;
	}
