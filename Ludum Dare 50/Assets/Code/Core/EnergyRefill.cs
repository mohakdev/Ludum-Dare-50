using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyRefill : MonoBehaviour
{
    bool isTouching;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Player") { return; }
        isTouching = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Player") { return; }
        isTouching = false;
    }
    private void Update()
    {
        if (!isTouching) { return; }
        if (Values.JumpEnergy < Values.MaxEnergy)
        {
            Values.AddEnergy(0.2f);
            EnergyBar.UpdateEnergyBar();
        }
    }
}
