using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;
    private Ability closeAbility = null;
    public UnityEngine.Object abilityScript = null;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 7f;
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (moveInput < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && closeAbility != null)
        {
            closeAbility.Reap();
        }
    }

    void OnBecameInvisible()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Reapable"))
        {
            Debug.Log("touching reapable");
            Debug.Log(closeAbility);
            closeAbility = other.gameObject.GetComponent<Ability>();
        }
    }
}
