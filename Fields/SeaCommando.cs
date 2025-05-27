using ComandoGame.Entity;

namespace ComandoGame.Fields
{
    internal class SeaCommando : Comando
    {
        public SeaCommando(string Name, string CodeName, StatusEnum Status)
            : base(Name, CodeName, Status){}

        public void Swim()
        {
            Console.WriteLine("Swiming");
        }
        public override void Attack()
        {
            Console.WriteLine($"Sea Commando Soldier named {this.Name} is Attack");
        }
    }
    
    
}

