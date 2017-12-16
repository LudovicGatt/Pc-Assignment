using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{

    public Text PlayrtOneScore;
    public Text PlayrtTowScore;

    private int TotalScorePlayerOne;
    private int TotalScorePlayerTow;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TotalScorePlayerOne = Scoreboard_Controller.totalPlayer1;
        PlayrtOneScore.text = TotalScorePlayerOne.ToString();

        TotalScorePlayerTow = Scoreboard_Controller.totalPlayer2;
        PlayrtTowScore.text = TotalScorePlayerTow.ToString();
    }
}
