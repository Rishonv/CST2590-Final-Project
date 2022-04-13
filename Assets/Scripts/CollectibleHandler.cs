using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleHandler : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private int score;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Collectible"))
        {
            Destroy(coll.gameObject);
            score++;
            scoreText.text = "Score: " + score;
        }
    }
}
