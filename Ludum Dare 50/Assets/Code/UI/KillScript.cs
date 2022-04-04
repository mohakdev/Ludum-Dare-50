using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public GameObject DeathScreen;
    bool alreadyRan = false;
    private void Update()
    {
        if (Values.JumpEnergy <= 0 && !alreadyRan)
        {
            //Kill The Player
            Time.timeScale = 0;
            Values.BlockGenPos = 20;
            DeathScreen.SetActive(true);
            alreadyRan = true;
        }
    }
}
