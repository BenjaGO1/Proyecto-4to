using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<InventoryItemData, InventoryItem> m_itemDictonary;
    public List<InventoryItem> inventory { get; private set; }

    private void Awake()
    {
        inventory = new List<InventoryItem>();
        m_itemDictonary = new Dictionary<InventoryItemData, InventoryItem>();
    }

    public InventoryItem Get(InventoryItemData referenceData)
    {
        if(m_itemDictonary.TryGetValue(referenceData, out InventoryItem value))
        {
            return value;
        }
        return null;
    }

    public void Add(InventoryItemData referenceData)
    {
        if(m_itemDictonary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddToStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictonary.Add(referenceData, newItem);
        }
    }

    //public void Remove(InventoryItemData referenceData)
    //{
    //    if(m_itemDictonary.TryGetValue(referenceData, out InventoryItem))
    //    {
    //        value.RemoveFromStack();
    //        if(value.stackSize == 0)
    //        {
    //            inventory.Remove(value);
    //            m_itemDictonary.Remove(referenceData);
    //        }
    //    }
    //}
}
