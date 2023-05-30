namespace AppAnimal.Modelo.Concretas.No
{/*
    public class Latitude: ValueObject
    {
        private readonly float value;

        public Latitude(float value)
        {
            if (value < -90 || value > 90)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Latitude should be between -90 and 90 degrees");
            this.value = value;
        }

        public static Latitude FromScalar(float value)
        {
            return new Latitude(value);
        }
        public static explicit operator float (Latitude latitude)
        {
            return latitude.value;
        }

        public static explicit operator Latitude(float value)
        {
            return new Latitude(value);
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }*/
}