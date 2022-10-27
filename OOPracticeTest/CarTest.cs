namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_msg_when_speedup_given_car_name_and_engine_type_gasoline()
        {
            //given
            Engine engine = new Engine("gasoline");
            Car car = new Car("cool car", engine);
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("cool car: speed up 30 km/h", msg);
        }

        [Fact]
        public void Should_return_msg_when_speedup_given_car_name_and_engine_type_electric()
        {
            Engine engine = new Engine("electic");
            Car car = new Car("cool car", engine);
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("cool car: speed up 25 km/h", msg);
        }
    }
}
