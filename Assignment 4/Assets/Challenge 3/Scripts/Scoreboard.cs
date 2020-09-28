/* 
 * Logan ross
 * assignment 4
 * displays game over and score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    public PlayerControllerX playerControllerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose! \nPress R to try again!";
        }

        //win con 10 pts
        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;

            scoreText.text = "You Win! \nPress R to try again!";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
