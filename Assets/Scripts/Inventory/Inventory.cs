using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class InventoryItem
{
    public string nameItem;
    public int idItem;
    public Sprite iconItem;
}

public class Inventory : MonoBehaviour
{
    public static Inventory instace;
    public List<InventoryItem> inventory;
    private void Awake()
    {
        instace = this;
    }
    public void AddItemToInventory(InventoryItem item)
    {
        inventory.Add(item);
    }
    public void RemoveItem(int id)
    {
        foreach(InventoryItem item in inventory)
        {
            if(item.idItem == id)
            {
                inventory.Remove(item);
                break;
            }
        }
    }

}
