using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform brother;  // Reference to the Brother's transform
    public float smoothSpeed = 0.125f;  // Smooth speed factor
    public Vector3 offset;  // Offset to keep the camera at a fixed position relative to the Brother

    private bool isFollowing = true;  // Flag to check if the camera should follow the Brother

    void LateUpdate()
    {
        // Only follow the Brother if isFollowing is true and the Brother still exists
        if (isFollowing && brother != null)
        {
            Vector3 desiredPosition = brother.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);  // Keep the camera's z-position constant
        }
    }

    // Method to stop the camera from following
    public void StopFollowing()
    {
        isFollowing = false;
    }
}
