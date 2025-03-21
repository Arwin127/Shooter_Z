using UnityEngine;
using UnityEngine.SceneManagement;

public class Brother : MonoBehaviour
{
    public float health = 100f; // Brother's health

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
        // Example: Destroy the NPC when health reaches zero
        Destroy(gameObject);
        Debug.Log("Brother died!");
    }
    public void GameOver()
    {
        if (health <= 0) 
        {SceneManager.LoadScene("GameOver"); }
    }
}
