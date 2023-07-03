using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
	[SerializeField]
	GameObject upgradePanelPrefab;
	[SerializeField]
	GameObject canvas;
	public GameObject thisObject; //Making variables public is a bad practice? Oh no :c
	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var upgradePanel = Instantiate(upgradePanelPrefab, new Vector3(0,0,0), Quaternion.identity);
			upgradePanel.transform.SetParent(canvas.transform, false);
			thisObject = this.gameObject;
			upgradePanel.GetComponent<Leveling>().objectRef = thisObject;
		}
	}
}
