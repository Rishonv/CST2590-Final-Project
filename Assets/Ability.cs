using UnityEngine;
using System;

public class Ability : MonoBehaviour
{
    public UnityEngine.Object abilityScript;

    public void Reap()
    {
        Debug.Log(GameObject.Find("Player"));
        var player = GameObject.Find("Player");
        var playerController = player.GetComponent<PlayerController>();

        // if we have a previous ability we clear it
        if (playerController.abilityScript != null)
        {
            Destroy(player.GetComponent(Type.GetType(playerController.abilityScript.name)));
        }

        playerController.abilityScript = abilityScript;
        if (abilityScript != null)
        {
            player.AddComponent(Type.GetType(abilityScript.name));
        }

        gameObject.SetActive(false);
    }
}
