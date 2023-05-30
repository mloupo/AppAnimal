using System;
namespace AppAnimalRev

{
    public class ConsoleInteractor : IStringInteractor
    {
        public string read()
        {
            return Console.ReadLine();
        }

        public void write(string line)
        {
            Console.WriteLine(line);
        }
    }

    public class UI_Interactor : IStringInteractor
    {
        public string read()
        {
            throw new NotImplementedException();
        }

        public void write(string line)
        {
            throw new NotImplementedException();
        }
    }

    public interface IStringInteractor
    {
        string read();

        void write(string line);
    }

    /* //en el main
     IStringInteractor interactor = new ConsoleInteractor();
     interactor.write(interactor.read());
    */
}
