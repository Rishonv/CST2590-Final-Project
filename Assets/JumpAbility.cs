using UnityEngine;

public class JumpAbility : MonoBehaviour
{
    public float jumpForce = 15.5f;

    private bool isGrounded = true;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.tag = "Reapable";
    }

    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        if ((Input.GetButtonDown("Jump")) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Terrain")
        {
            Debug.Log("grounded");
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == "Terrain")
        {
            Debug.Log("leaving floor");
            isGrounded = false;
        }
    }
}
