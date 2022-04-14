using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private int lives = 3;
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] Text tb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        tb.text = "Health: " + lives;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Traps") || other.gameObject.CompareTag("Reapable"))
        {
            lives--;
            tb.text = "Health: " + lives;
            if (lives == 0)
            {
                Death();
            }

            Debug.Log("You are dead");
        }
    }

    private void Death()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
