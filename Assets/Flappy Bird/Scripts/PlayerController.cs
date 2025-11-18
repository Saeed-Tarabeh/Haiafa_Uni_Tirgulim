using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpForce = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered with: " + other.name);

        if (other.CompareTag("Obstacle"))
        {
            enabled = false;
            Debug.Log("Game Over!");
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Triggered with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Obstacle"))
        {
            enabled = false;
            Debug.Log("Game Over!");
        }
    }

    
}
