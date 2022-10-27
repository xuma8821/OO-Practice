namespace OOPractice
{
    public class Vehicle
    {
        protected string name;
        protected int speed;
        //public Vehicle(string name, int speed)
        //{
        //    this.name = name;
        //    this.speed = speed;
        //}

        //public Vehicle()
        //{
        //}

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}