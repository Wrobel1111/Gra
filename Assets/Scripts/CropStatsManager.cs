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
	

	internal Vector3 PlaceForMyself()
	{
		foreach (var spot in usedCropsGridSO)
		{
			if (true)
			{
				
			}
		}
		return new Vector3(0,0,0);
	}

	public void AddNewPlant(CropsSO plantToAdd, int itsIndex)
	{
		//TODO: create a prefab of a plant and introduce here instantiation
		
		Instantiate(usedCropsList.assetForCrops[itsIndex], GetComponent<Transform>().localPosition, Quaternion.identity, this.GetComponentInParent<Transform>()); // Needs a correct spot to be placed (maybe a grid will be implemented?)
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
