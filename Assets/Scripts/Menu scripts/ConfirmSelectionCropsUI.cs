using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmSelectionCropsUI : MonoBehaviour
{
	[SerializeField]
	Dropdown x;
	CropsListSO cropsListSOVar;
	[SerializeField]
	GameObject panel;
	GameObject objectRef;
	void Start()
	{
		cropsListSOVar = panel.GetComponent<LoadCropsList>().cropsListSO;
		objectRef = panel.GetComponent<LoadCropsList>().objectRef;
	}

	
	public void Clicked()
	{
		objectRef.GetComponent<CropStatsManager>().AddNewPlant(cropsListSOVar.cropsList[x.value]);
		
	}
}
