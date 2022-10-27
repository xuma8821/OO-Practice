namespace OOPractice
{
    public class Car : Vehicle
    {
        private Engine engine;
        public Car(string name, Engine engine)
        {
            this.engine = engine;
            this.speed = this.engine.Speed;
            this.name = name;
        }
    }
}