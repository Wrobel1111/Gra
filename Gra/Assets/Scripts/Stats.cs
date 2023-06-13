using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Object stats")]
public class Stats : ScriptableObject
{
	public string objectName;
	public string objectDescription;
	public int level;
	public GameObject objectInWorld;
}
