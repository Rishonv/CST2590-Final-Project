using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayText : MonoBehaviour
{
    public GameObject uiObject;
    [SerializeField]
    //Text displayedText;
    string message;
    void Start()
    {
        uiObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            uiObject.GetComponent<Text>().text = this.message;
            // uiObject.GetComponent<Text>().fontSize = 100;
            uiObject.SetActive(true);
        }
        // Debug.Log(other.gameObject.name);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            uiObject.SetActive(false);
        }
        // Debug.Log(other.gameObject.name);
    }
}
