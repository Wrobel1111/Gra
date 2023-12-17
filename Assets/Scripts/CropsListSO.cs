using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crops List", menuName = "FIS/Crops List")]
public class CropsListSO : ScriptableObject
{
	public List<CropsSO> cropsList = new List<CropsSO>();
	/*
	* IMPORTANT:
	If multiple lists of crops will be introduced (and this is the intention of making it a SO), the CropSelection UI panel will
	have to be properly changed to catch the list on the fly - just like the upgrade UI panel does
	Yes, this does mean another bunch of tomfoolery and complete chaos with private/public variables in Click.cs script, but if You've got
	a better idea, no one stops You from implementing it. I am 𝗡𝗢𝗧 going to try to rewrite it - it works™ and that's what matters.
	*/
}
