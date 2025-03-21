using UnityEngine;

public class Zombie_Navigate : MonoBehaviour
{
    [SerializeField] public GameObject Target;  // The target that the zombie is chasing (e.g., Brother)
    [SerializeField] public float speed = 1f;   // Speed of the zombie

    void Start()
    {
        // Optionally, log an error if no Target is assigned
        if (Target == null)
        {
            Debug.LogError("Target is not assigned in the Inspector!");
        }
    }

    void Update()
    {
        // Only move towards the target if it is not null
        if (Target != null)
        {
            // Move the zombie towards the target's position
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
        }
        else
        {
            // Optionally, log a message or stop the zombie when the target is destroyed
            Debug.Log("Target is no longer available, zombie stops moving.");
        }
    }
}
