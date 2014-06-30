using UnityEngine;
using System.Collections;

public class CargarHighscore : MonoBehaviour {
	
	public TextMesh highscore;
	
	// Use this for initialization
	void Start () 
	{
		highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore", 0).ToString("D5");
	}
}
