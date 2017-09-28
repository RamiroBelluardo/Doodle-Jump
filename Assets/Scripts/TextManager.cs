using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	
	public Text gameOverText;
	public Text scoreText;


	public void ShowGameOverText(){

		gameOverText.gameObject.SetActive (true);
	}
	public  void ShowScoreText(float score){

		scoreText.text = "Score: " + score.ToString ();
	}
}
