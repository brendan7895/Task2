namespace Task1
{
    public abstract class Building
    {
        protected int xPos;
        protected int yPos;
        protected int health;
        protected string team;
        protected string symbol;

        public Building(int xPos, int yPos, int health, string team, string symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.team = team;
            this.symbol = symbol;
        }

        public abstract bool isDead();
        public abstract string ToString();
    }
}
