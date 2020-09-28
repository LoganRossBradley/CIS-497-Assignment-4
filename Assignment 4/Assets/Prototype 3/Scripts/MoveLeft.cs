/* 
 * Logan ross
 * assignment 4
 * moves objects and background to the left to simulate movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Networking;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -5;

    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //destroy the game object if it pasts left bound
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
