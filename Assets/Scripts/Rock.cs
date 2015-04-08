using UnityEngine;
using System.Collections;
using System;

public class Rock : Drawable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0,0,15) * Time.deltaTime);
	}

	void OnMouseDown() 
	{
		GameController.addClicks(1);
		Debug.Log ("Clicked!");
	}
}
