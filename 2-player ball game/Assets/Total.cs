using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{

    public Text PlayerOneScore;
    public Text PlayerTwoScore;

    private float TotalScorePlayerOne;
    private float TotalScorePlayerTwo;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TotalScorePlayerOne = Scoreboard_Controller.totalPlayer1;
        PlayerOneScore.text = TotalScorePlayerOne.ToString();

        TotalScorePlayerTwo = Scoreboard_Controller.totalPlayer2;
        PlayerTwoScore.text = TotalScorePlayerTwo.ToString();
    }
}
