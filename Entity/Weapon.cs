namespace ComandoGame.Entity
{
    internal class Weapon
    {
        string Name;
        string Prudocer;
        int BulletCapacity;

        public Weapon(string name, string prudocer, int bulletCapacity)
        {
            this.Name = name;
            this.Prudocer = prudocer;
            this.BulletCapacity = bulletCapacity;
        }

        public void Shoot()
        {
            this.BulletCapacity = this.BulletCapacity - 1;
            Console.WriteLine("shoot!");
            return;
        }
        
        
    }
}
