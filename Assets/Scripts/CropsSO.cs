using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crop", menuName = "FIS/Crops")]
public class CropsSO : ScriptableObject
{
	[SerializeField]
	public string cropName;
	[SerializeField]
	public UnityEngine.Object model;
	//public float growthTime;
	/*
	TODO: write all of crops' properties, like above
	*/
}