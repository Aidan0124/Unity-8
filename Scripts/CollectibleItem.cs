using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string itemName;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Managers.Inventory.AddItem(itemName);
            Destroy(this.gameObject);
            Debug.Log("Item collected: " + itemName);
        }
    }
}