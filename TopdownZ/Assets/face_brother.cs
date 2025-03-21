using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_Brother : MonoBehaviour
{
    private Transform m_transform;
    public GameObject Brother;  // Reference to the Brother GameObject

    void Start()
    {
        m_transform = transform;

        // Check if Brother is assigned
        if (Brother == null)
        {
            Debug.LogError("Brother GameObject is not assigned in the Inspector!");
        }
    }

    private void FacePlayerDirection()
    {
        if (Brother != null)
        {
            // Calculate the direction vector from the object to the Brother
            Vector2 direction = Brother.transform.position - m_transform.position;

            // Get the angle between the object and the Brother (in degrees)
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Set the rotation of the object to face the Brother
            Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            m_transform.rotation = rotation;
        }
        else
        {
            // If Brother is null (destroyed), stop rotating
            Debug.LogWarning("Brother is null, cannot face him anymore.");
        }
    }

    void Update()
    {
        // Only update rotation if Brother is still assigned
        if (Brother != null)
        {
            FacePlayerDirection();
        }
    }
}
