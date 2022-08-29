using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveItemInventory : MonoBehaviour
{
    public InventoryItem itemToReceive;

    public void Receive()
    {
        Inventory.instace.RemoveItem(itemToReceive.idItem);
    }
}
