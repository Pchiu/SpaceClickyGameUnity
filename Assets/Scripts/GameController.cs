using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static int clicks;
	public static long money;
	public static int clickMultiplier;
	private ObjectManager objectManager;
	// Use this for initialization
	void Start () {
		objectManager = GetComponent<ObjectManager>();
		NewGame ();
	}
	
	// Update is called once per frame
	void Update () {
		addIncome();
	}

	public void addIncome()
	{

	}

	public static void addClicks(int n)
	{
		clicks += n;
		addMoney (n * clickMultiplier);
		Debug.Log (clicks);
	}

	public static void addMoney(int n)
	{
		money += n;
	}

	void NewGame()
	{
		objectManager.newGame ();
		clicks = 0;
		money = 0;
		clickMultiplier = 1;
	}
}
