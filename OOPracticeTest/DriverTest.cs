namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class DriverTest
    {
        [Fact]
        public void Should_return_msg_when_driver_speedup_given_truck_name_and_speed()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            Driver driver = new Driver();
            driver.Drive(truck);
            //when
            string msg = driver.SpeedUp();

            //then
            Assert.Equal("Big Truck: speed up 10 km/h", msg);
        }

        [Fact]
        public void Should_return_msg_when_driver_speedup_given_car_name_and_speed()
        {
            //given
            Car car = new Car("Cool car", 30);
            Driver driver = new Driver();
            driver.Drive(car);
            //when
            string msg = driver.SpeedUp();
            //then
            Assert.Equal("Cool car: speed up 30 km/h", msg);
        }
    }
}
