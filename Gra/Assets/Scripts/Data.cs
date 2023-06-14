using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
	public Stats stats = new Stats();
}
[System.Serializable]
public class Stats
{
	public string objectName;
	public string objectDescription;
	public int levelMajor;
	public int levelMinor;
	public List<GameObject> objectsInWorld = new List<GameObject>();
}