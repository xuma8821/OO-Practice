namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class TruckTest
    {
        [Fact]
        public void Should_return_msg_when_speedup_given_car_name_and_speed()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            //when
            string msg = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", msg);
        }
    }
}
