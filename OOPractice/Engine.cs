namespace OOPractice
{
    public class Engine
    {
        private int speed;
        private string type;
        public Engine(string type)
        {
            this.type = type;
            if (type.Equals("gasoline"))
            {
                this.speed = 30;
            }
            else
            {
                this.speed = 25;
            }
        }

        public int Speed
        {
            get { return this.speed; }
        }
    }
}