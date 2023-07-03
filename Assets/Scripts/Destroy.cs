using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	[SerializeField]
	GameObject Panel;
	public void DestroyFunction()
	{
		Destroy(Panel);
	}
}
