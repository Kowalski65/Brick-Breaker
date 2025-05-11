using UnityEngine;

public class BallController : MonoBehaviour
{
    public float bounceForce = 7f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            
            Vector2 bounceDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;
            rb.velocity = bounceDirection * bounceForce;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {

            Vector2 bounceDirection = new Vector2(Random.Range(-1f, 1f), -1).normalized;
            rb.velocity = bounceDirection * bounceForce;
        }
        else if (collision.gameObject.CompareTag("Brick"))
        {

            Vector2 bounceDirection = new Vector2(Random.Range(-1f, 1f), -1).normalized;
            rb.velocity = bounceDirection * bounceForce;
        }
    }
}
