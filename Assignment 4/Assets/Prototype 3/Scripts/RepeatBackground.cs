/* 
 * Logan ross
 * assignment 4
 * repeats the background infinatly
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //save start pos as vector 3
        startPosition = transform.position;

        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //if the background is farther to the left that repeat width reset to start pos
        if(transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }

    }
}
