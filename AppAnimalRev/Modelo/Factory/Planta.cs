namespace AppAnimalRev
{
    public class Planta : Entity, IEntity
    {
        private string name = "Planta";
        public string GetName()
        {
            return Name;
        }

        public Planta()
        {
            Name = name;
        }
    }
}