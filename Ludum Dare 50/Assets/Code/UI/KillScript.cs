using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public GameObject DeathScreen;
    private void Update()
    {
        if (Values.JumpEnergy <= 0)
        {
            KillPlayer();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("KillBlock"))
        {
            KillPlayer();
        }
    }
    void KillPlayer()
    {
        //Kill The Player
        AudioManager.PlaySound(AudioManager.Instance.AudioList[3]);
        Time.timeScale = 0;
        Values.BlockGenPos = 20;
        DeathScreen.SetActive(true);
    }
}
