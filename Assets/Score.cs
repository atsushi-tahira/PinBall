using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	private int score;

	void Start () {
		Initialize ();		
	}

	void Update () {
		scoreText.text = "Score : " + score.ToString ();

	}

	void Initialize (){
		score = 0;
	}

	public void AddPoint (int points){
		score += points;
	}
}
