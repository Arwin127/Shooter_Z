using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;  // Bullet prefab reference
    public Transform Bulletspawn;        // The position where the bullet spawns 
    public float bulletSpeed = 10f;  // How fast the bullet moves
    public float fireRate = 0.2f;   // Time between shots
    public float nextFireTime = 0f; // Time until the next shot

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; 
        }
    }

    void Shoot()
    {
       
        GameObject Bullet = Instantiate(bulletPrefab, Bulletspawn.position, Bulletspawn.rotation);

        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            // If Rigidbody2D is missing, log an error
            Debug.LogError("No Rigidbody2D found on the bullet!");
            return;  // Exit the function if the Rigidbody2D is missing
        }
        

        rb.velocity = Bulletspawn.up * bulletSpeed;
        Destroy(Bullet, 1f);
    }

}
