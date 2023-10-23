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
	public void AddNewPlant(CropsSO plantToAdd)
	{
		//TODO: create a prefab of a plant and introduce here instantiation
	}
}
[System.Serializable]
public abstract class CropsGrowth
{
	public enum GrowthStage {Seed, Sprout, Grown, Blooming, Fruitage, Old, Dying}
	
}