namespace AppAnimal.Interfaces.Feeding
{    
    interface IOmnivorous : ICarnivorous, IHervivorous, IFrugivorous
    {
        void EatAll();
    }
}

