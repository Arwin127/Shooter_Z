using UnityEngine;

public class SisterFollow : MonoBehaviour
{
    public GameObject brother;          // Reference to the Brother (BigBrother)
    public float speed = 2f;            // Speed at which the Sister follows
    public float raycastDistance = 5f;  // Distance to check if Sister is too far from Brother
    public float stoppingDistance = 2f; // Distance at which the Sister stops following the Brother

    private bool isFollowing = false;   // Flag to check if the Sister should follow the Brother

    void Update()
    {
        // Check if Brother exists and if Sister should be following
        if (brother != null)
        {
            // Perform a raycast to check if the Brother is within range
            RaycastHit2D hit = Physics2D.Raycast(transform.position, brother.transform.position - transform.position, raycastDistance);

            // Debugging the raycast
            Debug.DrawRay(transform.position, brother.transform.position - transform.position, Color.red);

            // If the raycast hits the Brother (i.e., Brother is within range)
            if (hit.collider != null && hit.collider.gameObject == brother)
            {
                // Calculate the distance between Sister and Brother
                float distanceToBrother = Vector2.Distance(transform.position, brother.transform.position);

                // If the distance is greater than the stopping distance, resume following the Brother
                if (distanceToBrother > stoppingDistance)
                {
                    if (!isFollowing)
                    {
                        isFollowing = true;
                    }

                    transform.position = Vector2.MoveTowards(transform.position, brother.transform.position, speed * Time.deltaTime);
                }
                else
                {
                    // Stop following if Sister is too close (within stopping distance)
                    StopFollowing();
                }
            }
            else
            {
                // If raycast does not hit the Brother, start following
                if (!isFollowing)
                {
                    isFollowing = true;
                }

                // Move Sister towards the Brother if she's too far away
                transform.position = Vector2.MoveTowards(transform.position, brother.transform.position, speed * Time.deltaTime);
            }
        }
    }

    // Method to stop the Sister from following
    public void StopFollowing()
    {
        isFollowing = false;
        Debug.Log("Sister stopped following the Brother.");
    }

    // Optional: Visualize the raycast in the Scene View for debugging
    private void OnDrawGizmos()
    {
        if (brother != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, brother.transform.position);
        }
    }
}
