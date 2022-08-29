using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlots
{
    [SerializeField] private InventoryItemData itemData;
    [SerializeField] private int stackSize;


    public InventoryItemData ItemData => itemData;
    public int StackSize => stackSize;

    public InventorySlots(InventoryItemData source, int amount)
    {
        itemData = source;
        stackSize = amount;
    }

    public InventorySlots()
    {
        ClearSlot();
    }

    public void ClearSlot()
    {
        itemData = null;
        stackSize = -1;
    }

    public bool RoomLeftInStack(int AmountToAdd, out int amountRemaining)
    {
        amountRemaining = ItemData.MaxStackSize - stackSize;
        return RoomLeftInStack(AmountToAdd);
    }

    public bool RoomLeftInStack(int AmountToAdd)
    {
        if (stackSize + AmountToAdd <= itemData.MaxStackSize) return true;
        else return false;
    }

    public void AddToStack(int amount)
    {
        stackSize += amount;
    }

    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
    }
}
