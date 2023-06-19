namespace AppAnimalRev.Interfaces.Enviroment
{
    interface ITerrestrial : IEnviroment
    {
        void Crawl();
        void Walk();
        void Run();
    }
}