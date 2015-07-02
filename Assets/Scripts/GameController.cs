using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static int clicks;
	public static long money;
	public static int clickMultiplier;
	public static float incomeInterval;
	private float timeSinceLastInterval;
	private ObjectManager objectManager;
	private UpgradeManager upgradeManager;
	private UIController uiController;
	// Use this for initialization
	void Start () {
		objectManager = GetComponent<ObjectManager>();
		uiController = GetComponent<UIController>();
		upgradeManager = GetComponent<UpgradeManager>();
		NewGame ();
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastInterval += Time.deltaTime;
		if (timeSinceLastInterval >= incomeInterval)
		{
			addIncome();
			timeSinceLastInterval = 0.0f;
		}
		uiController.modifyMoneyCounter(money);
	}

	public void addIncome()
	{
		money += 1;
	}

	public static void addClicks()
	{
		clicks += 1;
		money += 1 * clickMultiplier;
		Debug.Log (money);
	}

	void NewGame()
	{
		objectManager.newGame ();
		clicks = 0;
		money = 0;
		clickMultiplier = 1;
		incomeInterval = 1;
		timeSinceLastInterval = 0.0f;
	}
}
