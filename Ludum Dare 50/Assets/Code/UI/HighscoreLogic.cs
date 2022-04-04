using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighscoreLogic : MonoBehaviour
{
    Text TextLabel;
    private void Start()
    {
        TextLabel = GetComponent<Text>();
        int Highscore = PlayerPrefs.GetInt("HighScore", 0);
        TextLabel.text = $"HIGHSCORE: {Highscore.ToString()}";
    }
}
