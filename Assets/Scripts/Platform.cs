using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {



	public BoxCollider2D playerBoxCollider2d;



	BoxCollider2D myBoxCollider2d;

	void Start () {
		
		myBoxCollider2d = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (playerBoxCollider2d.bounds.min.y < myBoxCollider2d.bounds.max.y && myBoxCollider2d.isTrigger == false)
			myBoxCollider2d.isTrigger = false;
		else if (playerBoxCollider2d.bounds.min.y > myBoxCollider2d.bounds.max.y && myBoxCollider2d.isTrigger == true)
			myBoxCollider2d.isTrigger = true;

}
}
