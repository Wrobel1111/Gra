using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gardener : MonoBehaviour
{
	public bool busy = false;
	Orders ordersClass = Orders.GetInstance();

	private Vector3 FindSpotForPlant()
	{
		throw new NotImplementedException();
	}
	public void ExecuteOrder(CropsSO plantToAdd)
	{
		throw new NotImplementedException(); //Told You so
		/*
		find a spot from CropsGridSO
		Instantiate(plantToAdd.model, FindSpotForPlant(), Quaternion.identity, this.GetComponentInParent<Transform>());
		
		while (Orders.queueOfPlants.Peek() != null)
		{
			ExecuteOrder(Orders.queueOfPlants.Dequeue());
		}
		busy = false;
		*/
	}
}
