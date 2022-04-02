/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
*/
public static class Values
{
    public static int JumpEnergy = 100;
    public static int JumpHeight = 8;
    public static int PlayerSpeed = 10;

    public static int SubtractEnergy(int EnergyToMinus)
    {
        JumpEnergy -= EnergyToMinus;
        return JumpEnergy;
    }
    public static int AddEnergy(int EnergyToAdd)
    {
        JumpEnergy += EnergyToAdd;
        return JumpEnergy;
    }
}
