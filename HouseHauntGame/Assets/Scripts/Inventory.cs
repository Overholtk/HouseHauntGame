using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Interactable> itemList;

    public Inventory()
    {
        itemList = new List<Interactable>();

        AddItem(new Interactable { itemType = Interactable.ItemType.SampleItem, amount = 1 });
        Debug.Log(itemList.Count);

        Debug.Log("Inventory");
    }

    public void AddItem(Interactable item)
    {
        itemList.Add(item);
    }
}
