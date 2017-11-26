using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class playert :FoodSharp {
	
	public int score  ;
	float resetDelay=10f;

	int toofood=72;
	public int b;
	public DisplayManager RefDisplayerManager;

	public float MassProperty {
		get {
			var parameter =  1/Mathf.InverseLerp( 0f , 10000f , score + 10 ) ;			
			return parameter ;
		}
	}

	void Start() {
		if (RefDisplayerManager == null) {
			RefDisplayerManager = GetComponentInParent<DisplayManager> ();
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Food") {
			score += 1;
			Destroy (other.gameObject);
			RefDisplayerManager.CurrentScoreText.text = score.ToString();
			totalFood--;
			b = totalFood;
		}
	}




	// Update is called once per frame
	void Update () {

	
		if (toofood==0) {
			if (score>=37) {
				Application.LoadLevel (2);

			}else {

				Application.LoadLevel (3);
			}

		} 
	}
	
	}



