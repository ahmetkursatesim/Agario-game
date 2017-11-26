using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public void RestartGame () {
		Application.LoadLevel (0);
		
	}
	public void startGame(){


		Application.LoadLevel (1);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
