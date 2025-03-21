using UnityEngine;
using UnityEngine.SceneManagement;

public class Brother : MonoBehaviour
{
    public float health = 100f;  // Brother's health
    public CameraFollow cameraFollowScript;  // Reference to the CameraFollow script
    public SisterFollow sisterFollowScript;  // Reference to the SisterFollow script

    // Method to take damage
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Handle death (you can customize this with an animation or game over logic)
    void Die()
    {
        // Stop following the Brother
        if (cameraFollowScript != null)
        {
            cameraFollowScript.StopFollowing();  // Stop the camera from following
        }

        if (sisterFollowScript != null)
        {
            sisterFollowScript.StopFollowing();  // Stop the Sister from following
        }

        // Destroy the Brother when health reaches zero
        Destroy(gameObject);
        Debug.Log("Brother died!");

        // Call GameOver after destruction
        GameOver();
    }

    // GameOver logic to load the "GameOver" scene
    void GameOver()
    {
        // You can add a delay here if you'd like to show a death animation or a message before transitioning
        SceneManager.LoadScene("GameOver"); // Load the "GameOver" scene
    }
}
