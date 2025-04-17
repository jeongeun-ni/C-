
namespace _250416GWAJE
{
    class Move
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Speed { get; set; }

        public string Emoji { get; set; }

        public void Left()
        {
            if (X > 0)
                X -= Speed;
        }

        public void Right()
        {
            if (X < 80)
                X += Speed;
        }

        public void Up()
        {
            if (Y > 0)
                Y -= Speed;
        }

        public void Down()
        {
            if (Y < 30)
                Y += Speed;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Emoji);
            Console.WriteLine();
        }

        public void Clear(int beforeX, int beforeY)
        {
            Console.SetCursorPosition(beforeX, beforeY);
            Console.WriteLine(' ');
        }

        internal void Clear(int beforeX, object beforeY)
        {
            Console.WriteLine(' ');
        }
    }



    internal class Program
    {
        static void Main()
        {
            Move player = new Move
            {
                X = 1,
                Y = 1,
                Speed = 1,
                Emoji = "♥"
            };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;

            while (true)
            {
                int beforeX = player.X;
                int beforeY = player.Y;

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.LeftArrow) player.Left();
                    else if (key == ConsoleKey.RightArrow) player.Right();
                    else if (key == ConsoleKey.UpArrow) player.Up();
                    else if (key == ConsoleKey.DownArrow) player.Down();
                    else if (key == ConsoleKey.Q) 
                    break;
                }

                player.Clear(beforeX, beforeY);
                player.Draw();


                Thread.Sleep(1);
            }

        }
    }
}
