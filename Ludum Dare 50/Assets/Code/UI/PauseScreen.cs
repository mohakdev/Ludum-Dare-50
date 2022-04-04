using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public void Restart()
    {
        LevelManager.RestartLevel();
        Time.timeScale = 1;
    }
    public void GoToMenu()
    {
        Time.timeScale = 1;
        LevelManager.LoadNewLevel(LevelManager.AllLevels.Menu);
    }
    public void PlayClickSound()
    {
        AudioManager.PlaySound(AudioManager.Instance.AudioList[2]);
    }
}
