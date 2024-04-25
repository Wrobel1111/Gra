using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Orders
{
	private static Orders _instance;
	public static Queue<CropsSO> queueOfPlants = new Queue<CropsSO>();
	private Orders(){}
	[SerializeField]
	List<GameObject> availableWorkers = new List<GameObject>();
	public static Orders GetInstance()
	{
		if (_instance == null)
		{
			_instance = new Orders();
		}
		return _instance;
	}
	public void InformAboutOrder(CropsSO plantToAdd)
	{
		for (int i = 0; i < availableWorkers.Count; i++)
		{
			if (!availableWorkers[i].GetComponent<Gardener>().busy)
			{
				availableWorkers[i].GetComponent<Gardener>().busy = true;
				//Take the order and execute it
				//! NOT IMPLEMENTED
				availableWorkers[i].GetComponent<Gardener>().ExecuteOrder(plantToAdd);
				return;
			}
		}
		queueOfPlants.Enqueue(plantToAdd);
	}
}