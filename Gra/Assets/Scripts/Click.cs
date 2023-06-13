using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
	[SerializeField]
	GameObject Prefab;
	[SerializeField]
	GameObject Canvas;
	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var upgradePanel = Instantiate(Prefab, new Vector3(0,0,0), Quaternion.identity);
			upgradePanel.transform.SetParent(Canvas.transform, false);
			
		}
	}
}
