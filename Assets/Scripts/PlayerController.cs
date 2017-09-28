using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	[SerializeField]
	float moveSpeed;

	[SerializeField]
	float jumpPower;

	[SerializeField]
	GameManager gameManager;

	[SerializeField]

	Camera cameraPlayer;



	Rigidbody2D myRigidbody2d;
	SpriteRenderer mySpriteRenderer;

	public float score = 0;
	float maxPosition= 0;
	void Awake(){

		myRigidbody2d = GetComponent<Rigidbody2D> ();
		mySpriteRenderer = GetComponent<SpriteRenderer> ();

	}

	void Update(){
		

		FlipCharacter ();
		//CheckBounds ();
		CheckIfDeath ();
		Score ();

		print (score);			
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		Movement ();



	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.name != "Main Camera") {
			myRigidbody2d.velocity = new Vector2 (myRigidbody2d.velocity.x, 0f);
			myRigidbody2d.AddForce (Vector2.up * jumpPower);
		}
	}
	void Movement(){
		myRigidbody2d.AddForce (Vector2.right * Input.GetAxis ("Horizontal") * moveSpeed);
	}

	void FlipCharacter(){
		
		if (Input.GetAxisRaw ("Horizontal") < 0)
			mySpriteRenderer.flipX = true;
		else if (Input.GetAxisRaw ("Horizontal") > 0)
			mySpriteRenderer.flipX = false;
}


	void CheckIfDeath(){
		if (cameraPlayer.transform.position.y- 5  > transform.position.y) {
			//GameOver.gameObject.SetActive (true);
			gameManager.GameOver();
			Destroy(gameObject);
		}
	}

	void CheckBounds(){

		if (transform.position.x < -4) {
			transform.position = new Vector2 (4.37f, transform.position.y);
		}
		if (transform.position.x > 4.37f) {
			transform.position = new Vector2 (-4, transform.position.y);
		}
		}

	void Score(){

		if (transform.position.y > maxPosition) {
			score += transform.position.y;
			maxPosition = transform.position.y;
		}

	}
}
