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
			if (upgradePanel.GetComponent<Leveling>() != null)
			/*
			* In order to achieve reusability of the code we have to do some guessing
			* At the beggining this code was used only to instantiate upgrade panel, which had Leveling component.
			* Now we would like to also instantiate other UI prefabs, so we've got to do this
			* this is basically if tree, which checks for specific components.
			* This WILL create problems, when an object will have two or more of those components, however I could not imagine such a case.
			* So this works.
			*/
			{
				upgradePanel.GetComponent<Leveling>().objectRef = thisObject;
			}
		}
	}
}
