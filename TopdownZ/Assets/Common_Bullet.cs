using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_Bullet : MonoBehaviour
{
    public float damage = 10f;
    public LayerMask zombieLayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the bullet hits a zombie, deal damage
        if ((zombieLayer.value & (1 << collision.gameObject.layer)) > 0)
        {
            // Get the Zombie_basic_HP component from the collided object
            Zombie_basic_HP zombie = collision.GetComponent<Zombie_basic_HP>();

            if (zombie != null)
            {
                Debug.Log("Zombie hit!");
                zombie.TakeDamage(damage); // Deal damage to zombie
                Destroy(gameObject); // Destroy the bullet
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add bullet movement logic here if needed
    }
}
