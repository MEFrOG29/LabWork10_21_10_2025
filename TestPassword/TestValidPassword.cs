using FluentAssertions;
using LabWork10;

namespace TestPassword
{
    public class TestValidPassword
    {
        [Fact]
        public void TestPasswordWithCorrectValueReturnTrue()
        {
            string password = "qwewe123W";
            Password.ValidPassword(password).Should().BeTrue();
        }

        [Fact]
        public void TestPasswordWithoutNumberReturnFalse()
        {
            string password = "qweweWdsadda";
            Password.ValidPassword(password).Should().BeFalse();
        }

        [Fact]
        public void TestPasswordWithoutLetterReturnFalse()
        {
            string password = "123456789";
            Password.ValidPassword(password).Should().BeFalse();
        }

        [Fact]
        public void TestPasswordNoCorrectLengthWithoutLetterReturnFalse()
        {
            string password = "123456";
            Password.ValidPassword(password).Should().BeFalse();
        }

        [Fact]
        public void TestPasswordNoCorrectLengthWithoutNumberReturnFalse()
        {
            string password = "teqweu";
            Password.ValidPassword(password).Should().BeFalse();
        }

        [Fact]
        public void TestPasswordNoCorrectLengthReturnFalse()
        {
            string password = "12ewr56";
            Password.ValidPassword(password).Should().BeFalse();
        }
    }
}