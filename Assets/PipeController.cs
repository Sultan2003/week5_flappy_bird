using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 2f;  // Speed at which the pipes move

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // If the pipe goes off-screen, destroy it
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
