using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
* Even though these are mostly methods, implementing them as interfaces would be undesirable, because it's easier to
* just add this as a script component and assign objects in editor, rather than playing with parameters. It works™
*/
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
		* UPDATE:
		* I'm just stupid. I tried to reference the class, not the object (duh)
		* This solution achieves referencing what already is set on creating a panel. Maybe there is some better way,
		* but this works™
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
