using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmSelectionCropsUI : MonoBehaviour
{
	[SerializeField]
	Dropdown x;
	[SerializeField]
	GameObject usedCropsManager;
	[SerializeField]
	CropsListSO cropsListSOVar;
	
	public void Clicked()
	{
		usedCropsManager.GetComponent<CropStatsManager>().AddNewPlant(cropsListSOVar.cropsList[x.value]);
	}
}
