using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelingMethods : MonoBehaviour
{
	GameObject obj;
	Button buM;//buttonUpgradeMajor
	Button bum;//buttonUpgradeMinor
	[SerializeField]
	GameObject panel;
	void Start()
	{
		obj = panel.GetComponent<Leveling>().objectRef;
		bum = panel.GetComponent<Leveling>().buttonUpgradeMinor;
		buM = panel.GetComponent<Leveling>().buttonUpgradeMajor;
		/*
		* I have absolutely no idea, why can't I just derive from Leveling and use the same variables, but compiler screams CS0120
		* I wasted on this two hours and concluded, that this abomination, no matter how much nonsense it represents, it just works™
		* Please leave me alone, don't @ me
		*/
	}
	public void Upgrade()
	{
		var objectStats = obj.GetComponent<Data>().stats;
		if (this.gameObject.name == "Button Minor")
		{
			if (objectStats.levelMinor < 8)
			{
				objectStats.levelMinor += 1;
			}
			else if (objectStats.levelMinor == 8)
			{
				objectStats.levelMinor += 1;
				bum.interactable = false;
				buM.interactable = true;
			}
		}
		else if (this.gameObject.name == "Button Major")
		{
			if (objectStats.levelMinor == 9)
			{
				objectStats.levelMajor += 1;
				objectStats.levelMinor = 0;
				bum.interactable = true;
				buM.interactable = false;
			}
		}
	}
}
