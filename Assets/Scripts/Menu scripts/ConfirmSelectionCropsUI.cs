using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmSelectionCropsUI : MonoBehaviour
{
	[SerializeField]
	Dropdown x;
	[SerializeField]
	CropsListSO cropsListSOVar;
	public void Clicked()
	{
		Debug.Log(cropsListSOVar.cropsList[x.value]);
	}
}
