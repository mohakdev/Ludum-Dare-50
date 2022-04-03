public static class Values
{
    public static int JumpEnergy = 80;
    public static int JumpHeight = 8;
    public static int PlayerSpeed = 10;
    public static float BlockGenPos = 20;
    public static int BlockNumber = 0;

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
    public static float ChangeBlockPos(float ChangeBy)
    {
        BlockGenPos += ChangeBy;
        return BlockGenPos;
    }
    public static void IncrementBlockNumber()
    {
        BlockNumber += 1;
    }
}
