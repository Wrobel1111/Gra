using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCropsList : MonoBehaviour
{
	[SerializeField]
	Dropdown cropsSelectionDropdown;
	[SerializeField]
	CropsListSO cropsListSO;
	public GameObject objectRef;

	List<string> listOfCropsNames = new List<string>();
	void Start()
	{
		for (int i = 0; i < cropsListSO.cropsList.Count; i++)
		{
			listOfCropsNames.Add(cropsListSO.cropsList[i].name);
		}
		cropsSelectionDropdown.AddOptions(listOfCropsNames);
	}
}