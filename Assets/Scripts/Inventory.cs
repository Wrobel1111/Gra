using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.IO;
using System.Text;
using Unity.Loading;
using System;
using UnityEngine.SceneManagement;

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
	public void Awake()
	{
		
	}
	public void Save()
	{
		using (FileStream fs = new FileStream(Application.persistentDataPath + "\\save.txt", FileMode.OpenOrCreate))
		{
			using(StreamReader str = new StreamReader(fs))
			{
				string line;
				int j = 0;
				int count = File.ReadLines(Application.persistentDataPath + "\\save.txt").Count();
				for (int i = 0; i < count; i++)
				{
					while ((line = str.ReadLine()) != null)
					{
						using(StreamWriter stwr = new StreamWriter(fs))
						{
							while (j <= i)
							{
								stwr.Write(inventory.ElementAt(j).Key.ToString());
								stwr.Write(",");
								stwr.Write(inventory.ElementAt(j).Value.ToString());
								stwr.Write("\n");
								j++;
							}
							while (j > i)
							{
								stwr.Write("");
								j++;
							}
						}	
					}
				}
			}
		}
	}
	public void Load()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		string line;
		int count = File.ReadLines(Application.persistentDataPath + "\\save.txt").Count();
		using (FileStream fs = new FileStream(Application.persistentDataPath + "\\save.txt", FileMode.Open))
		{
			using(StreamReader str = new StreamReader(fs))
			{
				for (int i = 0; i < count; i++)
				{
					while ((line = str.ReadLine()) != null)
					{
						inventory.Add(line.Remove(line.IndexOf(",")), float.Parse(line.Substring(line.IndexOf("," + 1))));
						//TODO: this implementation does not understand, that the string is the type. Good luck, future me!
					}
				}
			}
		}
	}
}