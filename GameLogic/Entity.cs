namespace GameLogic;
abstract class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
}