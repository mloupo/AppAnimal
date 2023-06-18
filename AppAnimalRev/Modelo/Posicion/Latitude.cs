using System;

namespace AppAnimal.Modelo.Posicion
{
    public class Latitude
    {
        private readonly float value;

        public Latitude(float value)
        {
            if (value < -90 || value > 90)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Latitude should be between -90 and 90 degrees");
            this.value = value;
        }
      
        public override string ToString()
        {
            return value.ToString();
        }
    }
}