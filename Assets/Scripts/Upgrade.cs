using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

	public string upgradeName;
	public string upgradeType;
	public int initialCost;
	public int currentCost;
	public int numPurchased;
	public float costIncrease;

	public Upgrade(string upgradeName, string upgradeType, int initialCost, float costIncrease)
	{
		this.upgradeName = upgradeName;
		this.upgradeType = upgradeType;
		this.initialCost = initialCost;
		this.currentCost = initialCost;
		this.costIncrease = costIncrease;
		this.numPurchased = 0;
	}

	public void purchaseUpgrade()
	{
		currentCost = (int)(currentCost * costIncrease);
		numPurchased++;
	}
}
