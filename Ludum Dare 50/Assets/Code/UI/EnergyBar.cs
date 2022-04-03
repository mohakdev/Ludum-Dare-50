using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    static Slider EnergySlider;
    public static EnergyBar Instance;
    private void Awake()
    {
        Instance = this;
        EnergySlider = GetComponent<Slider>();
        //When the game starts i am setting the Jump Energy to MAX.
        EnergySlider.maxValue = Values.MaxEnergy;
        Values.JumpEnergy = Values.MaxEnergy;
        UpdateEnergyBar();
    }
    /// <summary>
    /// Updates the energy for the energy bar in UI
    /// </summary>
    public static void UpdateEnergyBar()
    {
        EnergySlider.value = Values.JumpEnergy;
    }

}
