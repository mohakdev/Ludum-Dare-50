using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject TutorialScreen;
    private void Start()
    {
        if (!Values.TutorialShown)
        {
            TutorialScreen.SetActive(true);
            Time.timeScale = 0;
            Values.TutorialShown = true;
        }
    }
    // This function runs when Got It button is pressed in tutorial
    public void OkButton()
    {
        Time.timeScale = 1;
        Destroy(TutorialScreen);
    }
}
