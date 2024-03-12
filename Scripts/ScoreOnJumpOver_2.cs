using UnityEngine;
using TMPro;

public class ScoreOnJumpOver_2 : MonoBehaviour
{
    public GameObject playerOne; // Reference to Player One
    public GameObject playerTwo; // Reference to Player Two
    //public TextMeshProUGUI playerTwoScoreText; // Reference to the Player Two score text UI element
    public TextMeshProUGUI winText; // Reference to the win text UI element
    private int playerTwoScore = 0; // Score for Player Two
    void Start()
    {
        winText.gameObject.SetActive(false); // Initially hide the win text
    }

    // OnTriggerEnter is called when another collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if Player Two is above Player One
        if (other.gameObject == playerTwo && playerTwo.transform.position.y > playerOne.transform.position.y)
        {
            playerTwoScore++;   // Increment the score for Player Two      
             // Update the score text
            Debug.Log("Player Two Score: " + playerTwoScore);
            // Check if Player Two has won
            if (playerTwoScore >= 4)
            {
                winText.text = "Player Two Wins!";
                winText.gameObject.SetActive(true);
            }
        }
    }
}