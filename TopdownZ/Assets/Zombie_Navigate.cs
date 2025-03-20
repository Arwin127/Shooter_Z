using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Navigate : MonoBehaviour
{
    [SerializeField] public GameObject Target;
    [SerializeField] public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, speed* Time.deltaTime);
    }
}
