using System;
using ComandoGame.Entity;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Comando c = new Comando("James",8304053,StatusEnum.HIDING);
            Weapon W = new Weapon("M16","United States",250);
            
            Console.WriteLine("Hello World!");
        }
    }
}
