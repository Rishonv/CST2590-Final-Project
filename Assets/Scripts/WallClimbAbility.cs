using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClimbAbility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private bool isClimbSurface;
    [SerializeField] private bool isClimbing;
    [SerializeField] private float vertical = 0f;
    private float speed = 8f;
    private BoxCollider2D coll;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (isClimbSurface && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = rb.gravityScale * 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 5.5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Climbable")
        {
            isClimbSurface = true;
            Debug.Log("you can climb");
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Climbable")
        {
            isClimbSurface = false;
            isClimbing = false;
            Debug.Log("you can't climb");
        }
    }

}
