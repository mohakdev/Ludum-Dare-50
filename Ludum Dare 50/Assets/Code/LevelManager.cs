using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public enum AllLevels
    {
        Gameplay,
        Menu
    }
    //Making two methods like that allows us to use enum and string both as parameters
    public static void LoadNewLevel(AllLevels level)
    {
        SceneManager.LoadScene(level.ToString());
    }
    public static void LoadNewLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    public static void LoadNewLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
    /// <summary>
    /// This reloads the current level again.
    /// </summary>
    public static void RestartLevel()
    {
        //Don't change this SceneManager.GetActiveScene() does not work for some reason.
        LoadNewLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public static int CurrentLevel()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
