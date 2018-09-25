namespace Task1
{
    public class ResourceBuilding : Building
    {
        private string type;
        private int resourcesTick; //enter tick value in seconds
        private int total;

        public ResourceBuilding(int xPos, int yPos, int health, string team, string symbol, int resourcesTick, int total, string type) : base(xPos, yPos, health, team, symbol, type)
        {
            this.type = type;
            this.resourcesTick = resourcesTick;
            this.total = total;
        }

        public override bool isDead()
        {
            if (health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return type + ", " + symbol + "," + XPos + "," + YPos + "," + health;
        }

        public bool Resources(int counter)
        {
            bool value = false;
            if (counter % resourcesTick == 0)
            {
                total--;
                value = true;
                if (total <= 0)
                {
                    value = false;
                }
            }
            return value;
        }
    }
}
