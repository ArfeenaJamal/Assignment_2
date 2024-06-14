using System;
    class Place
{
    int x{ get; set; }
    int y{ get; set; }

    public Place(int x,int y)
        { 
        int X = x;
          int Y=y; 
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
                Place Y--;
                break;
            case 'D':
                Place Y++;
                break;
            case 'L':
                Place X--;
                break;
            case 'R':
                Place X++;
                break;
        }
    }



}
  
