using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A ve D için -1 ile 1 arası değer döner
        float moveZ = Input.GetAxis("Vertical");   // W ve S için -1 ile 1 arası değer döner

        Vector3 move = new Vector3(moveX, 0, moveZ) * speed;
        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
    }
}