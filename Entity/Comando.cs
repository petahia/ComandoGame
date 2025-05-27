namespace ComandoGame.Entity
{
    public enum StatusEnum
    {
        STANDING, WOLKING, HIDING
    }
    internal class Comando
    {
        public string Name;
        public string CodeName {get; set;}
        public string[] Tools;
        public StatusEnum Status;

        public Comando(string name, string codeName, StatusEnum status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Tools = ["hammer","chisel","rope","bag","water","bottle"];
            this.Status = status;
        }

        public void Wolk()
        {
            if (this.Status == StatusEnum.HIDING)
            {
                this.Status = StatusEnum.WOLKING;
            }
            else if (this.Status == StatusEnum.STANDING)
            {
                this.Status = StatusEnum.WOLKING;
            }
            Console.WriteLine(this.Status);
            
            return;
        }

        public void Hide()
        {
            this.Status = StatusEnum.HIDING;
        Console.WriteLine(this.Status);
        }

        public virtual void Attack()
        {
            Console.WriteLine(this.Name);
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                return this.Name;
            }
            else if (commanderRank == "COLONEL")
            {
                return this.CodeName;
            }
            else
            {
                return "classified information";
            }
            
            
        }
        
    
    
    }
}

