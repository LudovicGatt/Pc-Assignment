﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard_Controller : MonoBehaviour {

    public static Scoreboard_Controller instance;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    public int playerOneScore;
    public int playerTwoScore;
    private int buildIndex;

    public bool isLastLevel;
    public bool isLevel2;


    // Use this for initialization
    void Start () {

        instance = this;
        playerOneScore = playerTwoScore = 0;

	}
	
	// Update is called once per frame
	void Update () {
		


	}

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GivePlayerOneAPoint()
    {
        playerOneScore += 1;

        playerOneScoreText.text = playerOneScore.ToString();

        //Enter player 1 victory
        if (isLastLevel) {
            if (playerOneScore > 10)
            {
                SceneManager.LoadScene("Player1win");
            }
        }
        else if (isLevel2)
        {
            if (playerOneScore == 5)
            {
                LoadNextLevel();
            }
        }
        else
        {
            if (playerOneScore == 3)
            {
                LoadNextLevel();
            }
        }


    }
    public void GivePlayerTwoAPoint()
    {
        playerTwoScore += 1;

        playerTwoScoreText.text = playerTwoScore.ToString();

        //Enter player 2 victory
        if (isLastLevel)
        {
            if (playerTwoScore > 10)
            {
                SceneManager.LoadScene("Player2win");
            }
        }
        else if (isLevel2)
        {
            if (playerTwoScore == 5)
            {
                LoadNextLevel();
            }
        }
        else
        {
            if (playerTwoScore == 3)
            {
                LoadNextLevel();
            }
        }

    }

}
