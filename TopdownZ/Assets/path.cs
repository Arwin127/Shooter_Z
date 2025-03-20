using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    [SerializeField] private float moveSpeed;

    private int pointIndex;
    void Start()
    {
        transform.position = Points[pointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("A");
        if (pointIndex <= Points.Length - 1)
        {
            Debug.Log("B");
            transform.position = Vector2.MoveTowards(transform.position, Points[pointIndex].transform.position, moveSpeed * Time.deltaTime);
            if (transform.position == Points[pointIndex].transform.position) 
            {
                pointIndex += 1;
                Debug.Log("c");
            }
        }
    }
}
