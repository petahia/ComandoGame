using System;
using ComandoGame.Entity;
using ComandoGame.Fields;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Comando comando1 = new Comando("James","8304053",StatusEnum.WOLKING);
            Weapon weapon = new Weapon("M16","United States",250);
            Console.WriteLine(comando1.SayName("COLONEL"));

            comando1.CodeName = "7834490";
            Console.WriteLine(comando1.CodeName);
            
            
            // 7
            Comando comando = new Comando("moses","9983323",StatusEnum.HIDING);
            AirCommando airCommando = new AirCommando("Joni","99322323",StatusEnum.WOLKING);
            SeaCommando seaCommando = new SeaCommando("raul","24567453",StatusEnum.STANDING);
            SeaCommando waterAttack = new SeaCommando("raul","24567453",StatusEnum.STANDING);
            
            Comando[] soliders = new Comando[4] { comando, airCommando, seaCommando, waterAttack };

            foreach (Comando c in soliders)
            {
                c.Attack();
            }
            


        }
    }
}
