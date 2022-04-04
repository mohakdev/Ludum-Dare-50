public static class Values
{
    public static float MaxEnergy = 100;
    public static float JumpEnergy = 50;
    public static int JumpHeight = 8;
    public static int PlayerSpeed = 10;
    public static float BlockGenPos = 20;
    public static int BlockNumber = 0;
    public static bool TutorialShown = false;

    public static void SubtractEnergy(float EnergyToMinus)
    {
        JumpEnergy -= EnergyToMinus;
    }
    public static void AddEnergy(float EnergyToAdd)
    {
        JumpEnergy += EnergyToAdd;
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
