// Player.cs
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coinCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            Debug.Log("Coin collected. Total coins: " + coinCount);

            if (coinCount >= 4)
            {
                Debug.Log("Win! Collected 4 coins.");
            }
        }
    }
}