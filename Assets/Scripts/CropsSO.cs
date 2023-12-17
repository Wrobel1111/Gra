using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crop", menuName = "FIS/Crops")]
public class CropsSO : ScriptableObject
{
	[SerializeField]
	string cropName;
	[SerializeField]
	GameObject model;
	//public float growthTime;
	/*
	TODO: write all of crops' properties, like above
	*/
}