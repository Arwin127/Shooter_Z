using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float damage = 5f; 
    public float attackRange = 2f; 
    public float attackInterval = 1f; 
    public LayerMask playerLayer; 

    private float nextAttackTime;

    void Update()
    {
        // Check if enough time has passed for the next attack
        if (Time.time >= nextAttackTime)
        {
            // Raycast in the direction the zombie is facing (transform.up)
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, attackRange, playerLayer);

            if (hit.collider != null)
            {
                
               

                Brother brother = hit.collider.GetComponent<Brother>();
                if (brother != null)
                {
                    brother.TakeDamage(damage);
                }

                Sister sister = hit.collider.GetComponent<Sister>();
                if (sister != null)
                {
                    sister.TakeDamage(damage); 
                }
            }

            // Set the next attack time
            nextAttackTime = Time.time + attackInterval;
        }
    }

    void OnDrawGizmos()
    {
        // Draw the ray in the editor for debugging
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)transform.up * attackRange);
    }
}
