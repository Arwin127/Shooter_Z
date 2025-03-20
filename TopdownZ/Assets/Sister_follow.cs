using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sister_follow : MonoBehaviour
{
    [SerializeField] public GameObject BigBrother;
    [SerializeField] public float speed = 2f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, BigBrother.transform.position, speed * Time.deltaTime);
    }
}
