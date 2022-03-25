using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderHandler : MonoBehaviour
{
    private float vertical;
    private float speed = 8f;
    private bool isLadder;
    private bool isClimbing;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");

        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 5.5f;
        }
    }

    private void onTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void onTriggerExitr2D(Collider2D coll)
    {
        if (coll.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}
