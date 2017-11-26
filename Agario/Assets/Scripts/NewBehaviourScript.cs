using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public Transform Target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posScreen = Camera.main.WorldToScreenPoint (Target.position);
		posScreen.x /= Screen.width;
		posScreen.y /= Screen.height;
		
		
	}
}
