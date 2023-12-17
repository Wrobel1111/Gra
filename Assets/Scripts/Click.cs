using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
	[SerializeField]
	GameObject uiPanelPrefab;
	[SerializeField]
	GameObject canvas;
	public GameObject thisObjectRef; //Making variables public is a bad practice? Oh no :c
	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var uiPanel = Instantiate(uiPanelPrefab, new Vector3(0,0,0), Quaternion.identity);
			uiPanel.transform.SetParent(canvas.transform, false);
			if (thisObjectRef.GetComponent<Click>().uiPanelPrefab.name == "Panel upgrade")
			/*
			In order to achieve reusability of the code we have to do some guessing
			At the beggining this code was used only to instantiate upgrade panel, which had Leveling component.
			Now we would like to also instantiate other UI prefabs, so we've got to do this
			this is basically if tree, which checks for specific components.
			This WILL create problems, when an object will have two or more of those components, however I could not imagine such a case.
			So this works.
			*/
			{
				uiPanel.GetComponent<Leveling>().objectRef = thisObjectRef;
			}
			else if (thisObjectRef.GetComponent<Click>().uiPanelPrefab.name == "Panel choose crop")
			{
				uiPanel.GetComponent<LoadCropsList>().objectRef = thisObjectRef;
			}
		}
	}
}
