using System;
using System.Runtime.CompilerServices;
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
            private const int Size = 6;
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


        }
    }


}
  
