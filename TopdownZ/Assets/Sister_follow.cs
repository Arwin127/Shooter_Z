using UnityEngine;

public class SisterFollow : MonoBehaviour
{
    public GameObject brother;  // Reference to the Brother (BigBrother)
    public float speed = 2f;  // Speed at which the Sister follows

    private bool isFollowing = true;  // Flag to check if the Sister should follow the Brother

    void Update()
    {
        // Only move towards the Brother if isFollowing is true and the Brother exists
        if (isFollowing && brother != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, brother.transform.position, speed * Time.deltaTime);
        }
    }

    // Method to stop the Sister from following
    public void StopFollowing()
    {
        isFollowing = false;
    }
}
