using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IGameManager
{
    private Dictionary<string, int> items = new Dictionary<string, int>();

    // Implement the status property required by the IGameManager interface
    public ManagerStatus status { get; private set; }

    public void Startup()
    {
        // Add any initialization code here
        Debug.Log("Inventory manager starting...");
        status = ManagerStatus.Started; // Update the status when the manager has started
    }

    public void AddItem(string item)
    {
        if (!items.ContainsKey(item))
        {
            items[item] = 0;
        }
        items[item]++;
    }

    public int GetItemCount(string item)
    {
        if (!items.ContainsKey(item))
        {
            return 0;
        }
        return items[item];
    }

    public string GetInventoryContents()
    {
        string contents = "Inventory: ";
        foreach (KeyValuePair<string, int> item in items)
        {
            contents += item.Key + ": " + item.Value + ", ";
        }
        return contents;
    }
}