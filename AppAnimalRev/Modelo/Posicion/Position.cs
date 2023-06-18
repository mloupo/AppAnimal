namespace AppAnimal.Modelo.Posicion
{
    public class Position
    {
        private int x = 0;
        private int y = 0;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override string ToString()
        {
            return "Pos en X: " + x + ", Pos en y: " + y;
        }
    }
}
