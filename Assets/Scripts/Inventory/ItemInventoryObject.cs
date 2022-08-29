using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventoryObject : MonoBehaviour
{
    public InventoryItem item;

    public void AddInventory()
    {
        Inventory.instace.AddItemToInventory(item);
    }

}
