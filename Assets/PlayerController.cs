using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;  // The force with which the bird jumps
    private Rigidbody2D rb;         // Reference to the Rigidbody2D component

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // If the player presses the space bar or clicks, the bird jumps
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // End the game if the bird hits something
        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
          
            // Code to stop the game or restart the level
            Debug.Log("Game Over!");
            Time.timeScale = 0f;
        }
    }


    void Jump()
    {
        // Reset the velocity before jumping, so it doesn't accumulate force
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
