using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    GameObject Player;
    float PreviousPosition;
    float HighestPosition = 0f;
    float Score = 0f;
    Text Label;
    public static int DisplayScore;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PreviousPosition = Player.transform.position.y;
        Label = GetComponent<Text>();
    }
    private void LateUpdate()
    {
        if (PreviousPosition > HighestPosition)
        {
            HighestPosition = PreviousPosition;
        }
        if (HighestPosition < Player.transform.position.y)
        {
            //Increase the score
            Score += 0.2f;
            DisplayScore = (int)Score;
            Label.text = $"SCORE : {DisplayScore}";
        }
        PreviousPosition = Player.transform.position.y;
    }
}
