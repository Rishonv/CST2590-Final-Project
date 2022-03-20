using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumPad : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(
                            Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
