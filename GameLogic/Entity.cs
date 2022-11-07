namespace GameLogic;
abstract class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Entity(string name, int id, int health, int level)
    {
        this.Id = id;
        this.Name = name;
        this.Health = health;
        this.Level = level;
    }

        public override string ToString()
        {
            return $"{Name} {Id} {Health} {Level}";
        }

    }
