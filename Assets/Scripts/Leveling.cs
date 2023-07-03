using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leveling : MonoBehaviour
{
	public GameObject objectRef; //Also public, has to in order to work with Click.cs, refer to the comment on the line 11
	[SerializeField]
	public Button buttonUpgradeMajor;
	[SerializeField]
	GameObject descriptionMajorGO;
	[SerializeField]
	public Button buttonUpgradeMinor;
	[SerializeField]
	GameObject descriptionMinorGO;
	

	
	void Start()
	{
		var objectStats = objectRef.GetComponent<Data>().stats;
		if (objectStats.levelMinor < 10)
		{
			buttonUpgradeMajor.interactable = false;
		}
		else
		{
			buttonUpgradeMinor.interactable = false;
		}
	}
}
