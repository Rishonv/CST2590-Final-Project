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
        if (other.tag == "Player")
        {
            uiObject.GetComponent<Text>().text = this.message;
            uiObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            uiObject.SetActive(false);
        }
    }
}
