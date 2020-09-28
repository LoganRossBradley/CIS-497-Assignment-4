/* 
 * Logan ross
 * assignment 4
 * trigger zone for money that adds to the score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollideTrigger : MonoBehaviour
{
    private Scoreboard scoreboard;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.FindObjectOfType<Scoreboard>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            Scoreboard.score++;
        }
    }
}
