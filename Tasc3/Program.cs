var player1=new Player();
player1.Name="Ronaldo";
player1.Number=7;
player1.Position="Forward";
player1.Team="Real Madrid";


player1.ScoreGoal();
player1.AssistGoal("Karim Benzema");
System.Console.WriteLine(player1.GetInfo());










class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public void ScoreGoal()
    {
System.Console.WriteLine($"Player {Name} scores a goal.");
    }
     public void AssistGoal(string player_name)
    {
System.Console.WriteLine($"Player {Name} assists a goal for {player_name}.");
    }
     public string GetInfo()
    {
        return $"Enter player's name: {Name} \nEnter player's number:  {Number} \nEnter player's position:  {Position} \nEnter player's team:  {Team}";
    }

}