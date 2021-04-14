using CodeKatas.Katas.TcpStateMachine;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class TcpStateMachineTests
    {
        [Theory]
        [InlineData("CLOSE_WAIT", new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN" })]
        [InlineData("ESTABLISHED", new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK" })]
        [InlineData("LAST_ACK", new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN", "APP_CLOSE" })]
        [InlineData("SYN_SENT", new[] { "APP_ACTIVE_OPEN" })]
        [InlineData("ERROR", new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK", "APP_CLOSE", "APP_SEND" })]
        public void SampleTests(string expectedState, string[] inputValues)
        {
            // Arrange && Act
            var actualState = TCP.TraverseStates(inputValues);
            
            // Assert
            actualState.Should().Be(expectedState);
        }
    }
}