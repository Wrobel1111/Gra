
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropStats : MonoBehaviour
{
	List<GameObject> plantsInWorld;
	enum GrowthStage {Seed, Sprout, Grown, Blooming, Fruitage, Old, Dying}
	CropsSO whichCropAmI;
	[SerializeField]
	GameObject objectRef; //This has to be set on runtime, prefabs can't reference normal objects
	void Awake()
	{
		//Calls on instantiation
		//TODO: add itself to list of plants
	}
	
}
