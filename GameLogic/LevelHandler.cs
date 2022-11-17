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

    public int GainExperience(int experienceGained)
    {
        int levelsGained = 0;
        
        if (experienceGained <= -1) return levelsGained;
        
        Experience += experienceGained;
        
        while (Experience >= CalculateExperienceToLevel())
        {
            Experience -= CalculateExperienceToLevel();
            Level++;
            levelsGained++;
        }
        
        return levelsGained;
    }
    
    

    public override string ToString()
    {
        return $"Current Exp: {Experience}\n" +
               $"Current Level: {Level}\n" +
               $"Exp left to next level: {CalculateExperienceToLevel() - Experience}";
    }
}