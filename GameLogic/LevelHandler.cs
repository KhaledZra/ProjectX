namespace GameLogic;

public class LevelHandler
{
    private int _groundExperience;
    private float _levelScaler;
    public int Level { get; set; }
    public int Experience { get; set; }

    public LevelHandler()
    {
        _groundExperience = 100;
        _levelScaler = 1.5f;
        Level = 0;
        Experience = 0;
    }

    public int CalculateExperienceToLevel()
    {
        double expResult;
        
        if (Level == 1)
        {
            expResult = _groundExperience - Experience;
            return (int)expResult;
        }
        
        expResult = _groundExperience * Math.Pow(_levelScaler, (Level - 1));
        return (int)expResult;
    }

    public void CheckIfLevelUp(int experienceGained)
    {
        
    }
}