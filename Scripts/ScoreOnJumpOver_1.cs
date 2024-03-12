using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreOnJumpOver_1 : MonoBehaviour
{
    public GameObject playerOne; // Reference to Player One
    public GameObject playerTwo; // Reference to Player Two
    //public TextMeshProUGUI playerOneScoreText; // Reference to the Player One score text UI element
    public TextMeshProUGUI winText; // Reference to the win text UI element
    private int playerOneScore = 0; // Score for Player One
    void Start()
    {
        winText.gameObject.SetActive(false); // Initially hide the win text
    }

    // OnTriggerEnter is called when another collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if Player One is above Player Two
        if (other.gameObject == playerOne && playerOne.transform.position.y > playerTwo.transform.position.y)
        {
            playerOneScore++;   // Increment the score for Player One      
            Debug.Log("Player One score: " + playerOneScore); // Update the score text

            // Check if Player One has won
            if (playerOneScore >= 4)
            {
                winText.text = "Player One Wins!";
                winText.gameObject.SetActive(true);
               //StartCoroutine(RestartScene());
            }
        }
    }
    // Coroutine to wait for 5 seconds and then restart the scene
    // IEnumerator RestartScene()
    // {
    //     yield return new WaitForSeconds(5);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }
}
