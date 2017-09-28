using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	public GameObject player; 
	[SerializeField]
	public GameObject GameOver;

	float posicionActual;
	Vector3 cameraHeight; 

	// Use this for initialization
	void Start () {
		cameraHeight = transform.position; 

	}

	// Update is called once per frame
	void Update () {
		CameraFollowed ();
	}
	void CameraFollowed(){
		posicionActual = Mathf.Max (player.transform.position.y, transform.position.y);

		cameraHeight.y = posicionActual; 
		this.transform.position = cameraHeight; 
	}


	}



