using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leveling : MonoBehaviour
{
	public GameObject objectRef; //Also public, has to in order to work with Click.cs, refer to the comment on the line 11
	[SerializeField]
	Button buttonUpgradeMajor;
	[SerializeField]
	GameObject descriptionMajorGO;
	[SerializeField]
	Button buttonUpgradeMinor;
	[SerializeField]
	GameObject descriptionMinorGO;

	
	void Start()
	{
		if (objectRef.GetComponent<SOHandler>().stat.levelMinor < 10)
		{
			buttonUpgradeMajor.interactable = false;
			//descriptionMajorGO.GetComponent<>(); TODO: Set localization String Event to load proper table reference based on its availability, I'm too tired rn
		}
	}
	public static void LevelingFunction(GameObject objectRef)
	{

	}
}
