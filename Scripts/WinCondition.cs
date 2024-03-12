using UnityEngine;

public class GameWinCondition : MonoBehaviour
{
    private void Update()
    {
        // Check if the player has collected all 4 coins
        if (Managers.Inventory.GetItemCount("coin") >= 4)
        {
            // End the game
            Debug.Log("You've collected all the coins and won the game!");
            // Here you can add any code to end the game, like loading a victory scene
        }
    }
}