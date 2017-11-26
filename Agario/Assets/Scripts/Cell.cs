using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
public class Cell : NetworkBehaviour {
	

	public float moveforce=5;
	Rigidbody2D mybody;



	void Start(){
		mybody = this.GetComponent<Rigidbody2D> ();

	}

	void Update(){


			Vector2 moveVec = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))*moveforce;

			mybody.AddForce (moveVec);

		


	}


	
}
