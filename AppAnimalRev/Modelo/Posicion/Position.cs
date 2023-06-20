namespace AppAnimal.Modelo.Posicion
{
    public class Position
    {
        private int x;
        private int y; 

        public Position()
        {
            x= 0;
            y= 0;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override string ToString()
        {
            return "Pos en X: " + X + ", Pos en y: " + Y;
        }
    }
}
