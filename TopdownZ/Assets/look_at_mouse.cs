using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at_mouse : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform m_transform;
    
    void Start()
    {
        m_transform = transform;

        
    }
    
    private void LAmouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint
            (Input.mousePosition) - m_transform.position;
            float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;//this is the angle player should rotator towards
            Quaternion rotation = Quaternion.AngleAxis(angle -90, Vector3.forward); //vector 3 is Z axis
            m_transform.rotation = rotation;

    }
    // Update is called once per frame
    void Update()
    {
        LAmouse();
    }
}
