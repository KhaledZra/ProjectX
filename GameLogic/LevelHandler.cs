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
        Level = 1;
        Experience = 0;
    }

    private int CalculateExperienceToLevel()
    {
        double expResult;
        
        if (Level == 1)
        {
            return _groundExperience;
        }
        
        expResult = _groundExperience * Math.Pow(_levelScaler, (Level - 1));
        return (int)expResult;
    }

    public void GainExperience(int experienceGained)
    {
        if (experienceGained <= -1) return;
        
        Experience += experienceGained;
        
        while (Experience >= CalculateExperienceToLevel())
        {
            Experience -= CalculateExperienceToLevel();
            Level++;
        }
    }

    public override string ToString()
    {
        return $"Experience: {Experience}\nLevel: {Level}\nNeeded to level: {CalculateExperienceToLevel()}";
    }
}