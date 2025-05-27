namespace ComandoGame.Entity
{
    public enum StatusEnum
    {
        STANDING, WOLKING, HIDING
    }
    internal class Comando
    {
        string Name;
        int Id;
        string[] Tools;
        StatusEnum Status;

        public Comando(string name, int id, StatusEnum status)
        {
            this.Name = name;
            this.Id = id;
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
            if (this.Status == StatusEnum.WOLKING)
            {
                this.Status = StatusEnum.HIDING;
            }
            else if (this.Status == StatusEnum.STANDING)
            {
                this.Status = StatusEnum.HIDING;
            }
            Console.WriteLine(this.Status);
            return;
        }

        public void Attack()
        {
            Console.WriteLine(this.Name);
        }
        
        
    
    
    }
}

