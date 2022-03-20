using UnityEngine;

public class JumpAbility : MonoBehaviour
{
    public float jumpForce = 15.5f;
    private BoxCollider2D coll;
    //private bool isGrounded = true;
    private Rigidbody2D rb;
    [SerializeField] private LayerMask jumpableGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.tag = "Reapable";
        coll = GetComponent<BoxCollider2D>();
        jumpableGround = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        if ((Input.GetButtonDown("Jump")) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Terrain"))
    //     {
    //         Debug.Log("grounded");
    //         isGrounded = true;
    //     }
    // }

    // void OnCollisionExit2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Terrain"))
    //     {
    //         Debug.Log("leaving floor");
    //         isGrounded = false;
    //     }
    // }

    private bool IsGrounded()
    // checks overlap with ground layer using boxcast
    {
        return Physics2D.BoxCast(coll.bounds.center,
                                 coll.bounds.size, 0f,
                                 Vector2.down, .1f,
                                 jumpableGround);
    }
}
