using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject ParticleEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            AudioManager.PlaySound(AudioManager.Instance.AudioList[1]);
            Values.JumpEnergy = Values.MaxEnergy;
            EnergyBar.UpdateEnergyBar();
            GameObject EffectClone = Instantiate(ParticleEffect, transform.position, transform.rotation);
            EffectClone.SetActive(true);
            Destroy(gameObject);
        }
    }
}
