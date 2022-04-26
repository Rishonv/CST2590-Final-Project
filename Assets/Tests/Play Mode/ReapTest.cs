using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class ReapTest
{
    [UnityTest]
    public IEnumerator ReapTestWithEnumeratorPasses()
    {
        SceneManager.LoadScene("Level 1");
        GameObject[] playerObject = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] enemyObject = GameObject.FindGameObjectsWithTag("Reapable");

        Debug.Log(enemyObject);
        Debug.Log(playerObject);
        playerObject[0].transform.position = enemyObject[0].transform.position;
        playerObject[0].GetComponent<PlayerController>().OnTriggerEnter2D
                                                                    (enemyObject[0].GetComponent<BoxCollider2D>());
        // Debug.Log(playerObject.GetComponent<JumpAbility>());
        Assert.That(playerObject[0].GetComponent<JumpAbility>(), Is.Not.Null);

        yield return null;
        yield return null;
    }
}
