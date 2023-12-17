using System.Collections.Generic;

interface IManageInventory
{
	public void AddToInventory(object x);
	public bool RemoveFromInventory(object objectToRemove, float value);
	public void Save();
}