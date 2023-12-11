using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, IManageInventory
{
	Dictionary<object, float> inventory = new Dictionary<object, float>();

	public void AddToInventory(CropsSO cropToAdd)
	{
		if (inventory.ContainsKey(cropToAdd))
		{
			inventory[cropToAdd] += 1.0f;
		}
		else
		{
			inventory.Add(cropToAdd, 1.0f);
		}
	}
	public void AddToInventory()
	{

	}
	public bool RemoveFromInventory(object objectToRemove, float value)
	{
		if (inventory.ContainsKey(objectToRemove))
		{
			if (inventory[objectToRemove] >= value)
			{
				inventory[objectToRemove] -= value;
				return true;
			}
			else
			{
				Debug.Log("Not enough items");
				return false;
			}
		}
		else
		{
			Debug.Log("Object not in inventory");
			return false;
		}
	}
}
