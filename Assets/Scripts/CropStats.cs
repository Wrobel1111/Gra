using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropStats : MonoBehaviour
{
	public CropsGrowth cropsGrowth = new CropsGrowth();
}
[System.Serializable]
public class CropsGrowth
{
	public enum GrowthStage {Seed, Sprout, Grown, Blooming, Fruitage, Old, Dying}
	public List<GameObject> plantsInWorld = new List<GameObject>();
	public void PlantNewCrop()
	{
		
	}
}