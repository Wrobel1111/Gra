using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropStatsManager : MonoBehaviour, ICropsManager
{
	public List<GameObject> plantsInWorld = new List<GameObject>();
	[SerializeField]
	CropsListSO usedCropsList;
	[SerializeField]
	public GameObject ObjectRef;
	[SerializeField]
	GameObject barn;
	public void AddNewPlant(CropsSO plantToAdd)
	{
		//TODO: create a prefab of a plant and introduce here instantiation
		//!TEMPORARY
		SendToBarn(plantToAdd);
	}
	public void SendToBarn(object x)
	{
		try
		{
			barn.GetComponent<Inventory>().AddToInventory(x);
		}
		catch (System.Exception ex)
		{
			Debug.Log("penis");
		}

	}
}
