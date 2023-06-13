using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Object stats", menuName = "FIS/GameStats")]
public class Stats : ScriptableObject
{
	public string objectName;
	public string objectDescription;
	public int levelMajor;
	public int levelMinor;
	public List<GameObject> objectsInWorld = new List<GameObject>();

	public void Upgrade(GameObject objectRef)
	{

	}
}
