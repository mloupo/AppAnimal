using System;

namespace AppAnimal.Modelo.Concretas.No
{
    internal class Longitude
     {
         private readonly float value;

         public Longitude(float value)
         {
             if (value < 180 || value > 180)
                 throw new ArgumentOutOfRangeException(nameof(value), value, "Longitude should be between -180 and 180 degrees");
             this.value = value;
         }
    
         public override string ToString()
         {
             return value.ToString();
         }
     }
}