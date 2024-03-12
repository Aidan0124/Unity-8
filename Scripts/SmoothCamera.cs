using UnityEngine;

public class FollowPlayers : MonoBehaviour
{
    public Transform playerOneTransform; // Reference to Player One's Transform
    public Transform playerTwoTransform; // Reference to Player Two's Transform

    public float smoothSpeed = 0.125f; // The speed at which the camera will interpolate to the target position
    public float minDistance = 5f; // The minimum distance between players for the camera to start moving back
    public float maxDistance = 10f; // The maximum distance between players for the camera to stop moving back
    public Vector3 offset = new Vector3(0, 10, 0); // The offset of the camera from the midpoint of the two players

    private void FixedUpdate()
    {
        // Calculate the midpoint between the two players
        Vector3 midpoint = (playerOneTransform.position + playerTwoTransform.position) / 2.0f;

        // Calculate the distance between the two players
        float distance = Vector3.Distance(playerOneTransform.position, playerTwoTransform.position);

        // Calculate the new position for the camera
        Vector3 desiredPosition = midpoint + offset;

        // Adjust the Z position of the camera based on the distance between the two players
        if (distance > minDistance)
        {
            float zOffset = Mathf.Lerp(0, maxDistance - minDistance, (distance - minDistance) / (maxDistance - minDistance));
            desiredPosition.z -= zOffset;
        }

        // Interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the position of the camera
        transform.position = smoothedPosition;
    }
}