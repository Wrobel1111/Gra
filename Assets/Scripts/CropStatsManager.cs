using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropStatsManager : MonoBehaviour
{
	public List<GameObject> plantsInWorld = new List<GameObject>();
	[SerializeField]
	CropsListSO usedCropsList;
	[SerializeField]
	public GameObject ObjectRef;
	[SerializeField]
	GameObject barn;
	[SerializeField]
	GameObject usedCropsGrid;
	[SerializeField]
	CropsGridSO usedCropsGridSO;
	[SerializeField]
	GameObject[] workers;
	Orders ordersClass = Orders.GetInstance();
	public void AddNewPlant(CropsSO plantToAdd)
	{
		//! NOT IMPLEMENTED
		//ordersClass.InformAboutOrder(plantToAdd);
	}
	public void SendToBarn(object x)
	{
		try
		{
			barn.GetComponent<Inventory>().AddToInventory(x);
		}
		catch (System.Exception ex)
		{
			Debug.Log("penis: " + ex);
		}

	}
}
