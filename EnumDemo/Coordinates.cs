using System;


namespace EnumDemo
{
    public struct Coordinates
    {
        private int x;
        private int y;
        public Coordinates(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
          Console.WriteLine(x + "  " + y);
        }

    }
}
