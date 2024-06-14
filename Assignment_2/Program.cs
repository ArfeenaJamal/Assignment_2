using System;
class Place
{
    int X{get;set; }
    int Y{ get;set; }

    public Place(int x,int y)
        { 
        int X = x;
        int Y =y; 
    }

}
class Participants
{
    public string Name { get; set; }
    public Place Place { get; set; }
    public int Gemcount { get; set; }
    public Participants(string name, Place place)
    {
        Name = name;
        Place = place;
        Gemcount = 0;
    }
    public void changeplace(char direction)
    {
        switch (direction)
        {
            case 'U':
                Place Y-- ;
                break;
            case 'D':
                Place Y++ ;
                break;
            case 'L':
                Place X-- ;
                break;
            case 'R':
                Place X++ ;
                break;
        }
    }
    class Cells
    { public string Occurance{ get; set; }
        public Cells(string occurance)
        {
            Occurance = occurance;

        }
        class Board
        {
            private const int size = 6;
            private Cells[] Grid{ get; set; }
            private Random random;
        }
        public Board()
        { Grid = new Cells[Size, Size];
            random = new Random;
            InitializeBoard();
        }
         private void InitializeBoard ()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < sizeof; j++)
                {
                    Grid[i, j] = new Cells("-");
                }
                }
            Grid[0,0] Occurance = "p1";
            Grid[size - 1, sizeo - 1] = "p2";
            for (int i = 0;i<6;i++)
            {
                int x=random.Next(0,size);
                int y = Random.Next(0,size);
                if (Grid[x,y]Occurance=="-")
                        { Grid[x, y].Occurance = "G"; }
            for (int i=0;i<6;i++)
            { int x = Random.Next(0, size);
                int y = Random.Next(0, size);
                if (Grid[x,y]Occurance=="-")
                        { Grid[x, Y].Occupant = "0";
            }
            }
            }
    public void display()
    {
        for(int i = 0;i<size ; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine(Grid[i, j].Occurance + "");

            }
            Console.WriteLine(); 
            
           
        }


        
    }
    public bool Isvalidmove (Player,player char direction)
       { int new X= Player.position.X;
        int new y= Player.position.y;
    }
    switch(direction)
        {case 'U':
        new Y--;
                    case 'U':
                newY--;
                break;
            case'D':
                newy++;
                break;
            case'L':
                newX--;
                break;
            case'R':
                newX++;
                break;
        }

 if(newX<0|| newX>= Size||newY<0||newY>= Size)
  {  
    return false;
  }

if(Grid[newY,newX].Occupant=="0')
    { return false; }
return true;

    }

  public void collectGem(Player player)
{ 
     if (Grid[player.Position.Y,player.Position.X].Occupant=="G")
    { player.GemCount++;
        Grid[player.Position.Y, player.Position.X].Occupant = "-";
    }
    
}
}

class Game
{ 
    private Board Board { get; set; }
    private PLayer Player1 { get; set; }
    private Player Player2 { get;set; }
    private Player CurrentTurn { get;set; }
    private int TotalTurns { get; set; }private int TotalTurn { get; set; }

    public Game()
    {
        Board = new Board();
        Player1 = new PLayer("P1", new Position(0, 0));
        Player2 = new Player("p2", new Position(5, 5));
        CurrentTurn = Player1;
        TotalTurns = 0;
    }

    public void start()
    {
        while (!IsGameOver())
        {

            Console.WriteLine($"Turn {TotalTurns + 1}: {CurrentTurn.Name}'s turn");
            Board.Display();
            Console.WriteLine("enter direction (U/D/L/R):");
            char direction = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (Board.IsValidMove(CurrentTurn, direction))
            {
                CurrentTurn.Move(direction);
                Board.CollectGem(CurrentTurn);
                TotalTurns++;
                SwitchTurn();

            }
            else
            {

                Console.WriteLine("Invalid move! Try again.");
            }
        }

        AnnounceWinner();
    }

    private void SwitchTurn()
    {
        if (CurrentTurn == Player1)
        {
            CurrentTurn = Player2;
        }
        else
        {

            CurrentTurn = Player1;
        }
    }

    private bool IsGameover()
    {
        return TotalTurns >= 30;
    }

    private void AnnounceWinner()
    {
        Console.WriteLine("Game Over!");
        if (Player1.GemCount < Player2.GemCount)
        {
            Console.WriteLine("{Player1 wins!");
        }
        else if (Player1.GemCount < Player2.GemCount)
        {
            Console.WriteLine("Player 2 wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.start();
    }
}
  
