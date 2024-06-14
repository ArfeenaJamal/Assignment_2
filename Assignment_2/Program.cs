using System;
class Position
{
    int X{get;set; }
    int Y{ get;set; }

    public Position(int x,int y)
        { 
        X = x;
        Y =y; 
    }

}
class Player
{
    public string Name { get; set; }
    public Position Position { get; set; }
    public int GemCount { get; set; }
    public Player(string name, Position position)
    {
        Name = name;
        Position = position;
        GemCount = 0;
    }
    public void Move(char direction)
    {
        switch (direction)
        {
            case 'U':
                Position.Y-- ;
                break;
            case 'D':
               Position.Y++ ;
                break;
            case 'L':
                Position.X-- ;
                break;
            case 'R':
                Position.X++ ;
                break; 
        }
    }
    class Cells
    { public string Occupant{ get; set; }
        public Cells(string occupant)
        {
            Occupant= occupant;

        }
        class Board
        {
            private const int Size = 6;
            private Cells[,] Grid{ get; set; }
            private Random random;
        }
        public Board()
        { Grid = new Cells[Size,Size];
            random = new Random();
            InitializeBoard();
        }
         private void InitializeBoard ()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i,j] = new Cells("-");
                }
                }
            Grid[0,0].Occupant = "p1";
            Grid[Size-1,Size-1].Occupant= "p2";
            for (int i = 0; i < 6; i++)
            {
                int x = random.Next(0, Size);
                int y = random.Next(0, Size);
                if (Grid[x, y].Occupant == "-")
                { 
                    Grid[x, y].Occupant = "G";
                }
            }
            for (int i=0;i<6;i++)
            {  
                int x = random.Next(0,size);
                int y = random.Next(0,size);
                if (Grid[x,y].Occupant=="-")
                        { 
                    Grid[x,Y].Occupant == "0";
            }
            }
            }
    public void Display()
    {
        for(int i = 0;i<Size ; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.WriteLine(Grid[i, j].Occupant + "");

            }
            Console.WriteLine(); 
            
           
        }


        
    }
    public bool Isvalidmove (Player player char direction)
       { 
            int new X= player.Position.X;
            int new Y= player.Position.Y;
    }
    switch(direction)
        { 
                case 'U':
                newY--;
                break;
                case'D':
                newY++;
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
    { 
    return false;
}
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
    private Player Player1 { get; set; }
    private Player Player2 { get;set; }
    private Player CurrentTurn { get;set; }
    private int TotalTurn { get; set; }

    public Game()
    {
        Board = new Board();
        Player1 = new Player("P1", new Position(0, 0));
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
  
