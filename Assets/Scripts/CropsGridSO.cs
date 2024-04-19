using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Crops Grid", menuName = "FIS/Crops Grid")]
public class CropsGridSO : ScriptableObject, IEnumerable, IEnumerator
{
	public class CropSpot
	{
		public Vector3 spot;
		public bool isTaken;
		CropSpot(Vector3 spot, bool isTaken)
		{
			this.spot = spot;
			this.isTaken = isTaken;
		}
	}
	public CropSpot[] cropSpots;
	int position = -1;
	public void Reset()
    {
        position = -1;
    }
	//public List<Vector3> spotsForPlants = new List<Vector3>();
	//public List<bool> isSpotTaken = new List<bool>();
	//Because Unity doesn't serialize dictionaries, we have to use two lists and hope they are working together. Also enumerating doesn't work, so here is override:

}
