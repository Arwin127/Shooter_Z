using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_Brother : MonoBehaviour
{
    private Transform m_transform;
    public GameObject Brother;  
   
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

        Vector2 direction = Brother.transform.position - m_transform.position;   
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

       
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); 
        m_transform.rotation = rotation;
    }

    void Update()
    {
        FacePlayerDirection();
    }
}
