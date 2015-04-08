using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ObjectManager : MonoBehaviour {

	// Properties

	//
	private List<Drawable> drawables;

	// Object prefab member variables
	public Rock rock;
	// Use this for initialization
	void Start () {
		drawables = new List<Drawable>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void newGame()
	{
		if (drawables == null)
		{
			drawables = new List<Drawable>();
		}
		addDrawable (rock, new Vector3(-5,0,0), Quaternion.identity);
	}

	public void addDrawable(Drawable drawable)
	{
		drawables.Add ((Drawable)Instantiate (drawable, new Vector3(0,0,0), Quaternion.identity) );
	}

	public void addDrawable(Drawable drawable, Vector3 position, Quaternion rotation)
	{
		drawables.Add ((Drawable)Instantiate (drawable, position, rotation) );
	}
}
