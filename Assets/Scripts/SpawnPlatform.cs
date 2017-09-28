using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour {



	[SerializeField]
	GameObject platformPrefab;

	[SerializeField]
	GameObject playerTransform;

	float currentHeight;
	int blocksInSection= 5;
	private float blockOffset= 3f;
	private int flag= -1;




	private Vector2 originPosition;


	// Use this for initialization
	void Start () {

		currentHeight = 0;
		SpawnSection ();
	}
	
	// Update is called once per frame
	void Update(){
		if (currentHeight - playerTransform.transform.position.y < 1){

			SpawnSection ();
	}
}

	void SpawnSection (){
		for (int i = 0; i < blocksInSection; i++) {

			currentHeight += blockOffset;
			CreatePlatformBlock (currentHeight);

		}
	}

	void CreatePlatformBlock (float height){
		GameObject block = Instantiate (platformPrefab) as GameObject;

		Vector3 pos = block.transform.position;
		pos.y = height;
		pos.x = flag * Random.Range (-3f,-0.5f);
		flag *= -1;
		block.transform.position = pos;
		block.transform.parent = this.transform;
	
	}
}
