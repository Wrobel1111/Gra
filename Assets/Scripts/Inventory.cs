using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.IO;
using System.Text;

public class Inventory : MonoBehaviour, IManageInventory
{
	
	Dictionary<object, float> inventory = new Dictionary<object, float>();

	public void AddToInventory(object objectToAdd)
	{
		if (inventory.ContainsKey(objectToAdd))
		{
			inventory[objectToAdd] += 1.0f;
			//Debug.Log(objectToAdd + " " + inventory[objectToAdd]);
		}
		else
		{
			inventory.Add(objectToAdd, 1.0f);
		}
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
    public void Save()
    {
		string[,] content = null;

		for (int i = 0; i < inventory.Count; i++)
		{
			content[i,0] = inventory.ElementAt(i).Key.ToString();
			content[i,1] = inventory.ElementAt(i).Value.ToString();
		}
	}
}
