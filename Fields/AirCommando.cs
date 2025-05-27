using ComandoGame.Entity;

namespace ComandoGame.Fields
{
    internal class AirCommando : Comando
    {
        public AirCommando(string Name, string CodeName, StatusEnum Status)
            : base(Name, CodeName, Status)
        {
        }

        public void JumpOut()
        {
            Console.WriteLine("jump out!");
        }

        public override void Attack()
        {
            Console.WriteLine($"Air Commando Soldier named {this.Name} is Attack");
        }
    
        


    }
}