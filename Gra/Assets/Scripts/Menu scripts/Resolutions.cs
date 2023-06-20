using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolutions : MonoBehaviour
{
	[SerializeField]
	Dropdown resolutionsDropdown;
	Resolution[] resolutions;
	List<string> options = new List<string>();

	void Start()
	{
		resolutions = Screen.resolutions;
		resolutionsDropdown.ClearOptions();
		int currentResolutionIndex = 0;

		for (int i = 0; i < resolutions.Length; i++)
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add(option);
			if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
			{
				currentResolutionIndex = i;
			}
		}
		resolutionsDropdown.AddOptions(options);
		resolutionsDropdown.value = currentResolutionIndex;
		resolutionsDropdown.RefreshShownValue();
	}
}
