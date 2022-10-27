namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_msg_when_speedup_given_car_name_and_speed()
        {
            //given
            Car car = new Car("cool car",30);
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("cool car: speed up 30 km/h", msg);
        }
    }
}
