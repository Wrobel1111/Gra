interface IManageInventory
{
	public void AddToInventory(CropsSO x);
	public void AddToInventory();
	public bool RemoveFromInventory(object objectToRemove, float value);
		
}