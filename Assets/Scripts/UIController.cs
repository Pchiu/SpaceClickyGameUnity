using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

	public Text moneyCounter;
	public void modifyMoneyCounter(long money)
	{
		moneyCounter.text = "Money: " + money;
	}
}
