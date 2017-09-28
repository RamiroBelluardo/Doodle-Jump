using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[SerializeField]
	TextManager textManager;

	[SerializeField]
	PlayerController playerControllerScript;

void Update(){

		textManager.ShowScoreText (playerControllerScript.score);
		

		}


	public void GameOver(){
	    textManager.ShowGameOverText ();
}
}