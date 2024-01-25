using Xunit;

namespace KataBowling.Test
{
    public class GameTest
    {
        [Fact]
        public void WhenRoll_WithNegativePinNumber_ShouldThrowGameException()
        {

        }

        [Fact]
        public void WhenRoll_WithPinNumberGreatherThat10_ShouldThrowGameException()
        {

        }

        [Fact]
        public void WhenRoll_WithGameEnded_ShouldThrowGameException()
        {

        }

        [Fact]
        public void WhenFrameIsStrike_ShouldReturnTrue()
        {

        }

        [Fact]
        public void WhenFrameIsSpare_ShouldReturnTrue()
        {

        }

        [Fact]
        public void WhenRoll_With1PinKnockedDownByRoll_ScoreShouldReturn20()
        {
        }

        [Fact]
        public void WhenRoll_WithNoPinKnockedDownByRoll_ScoreShouldReturnO()
        {

        }

        [Fact]
        public void WhenRoll_WithOnlyStrike_ScoreShouldReturn300()
        {
            var game = new Game();
            //Strike on frame 1
            game.Roll(10);
            //Strike on frame 2
            game.Roll(10);
            //Strike on frame 3
            game.Roll(10);
            //Strike on frame 4
            game.Roll(10);
            //Strike on frame 5
            game.Roll(10);
            //Strike on frame 6
            game.Roll(10);
            //Strike on frame 7
            game.Roll(10);
            //Strike on frame 8
            game.Roll(10);
            //Strike on frame 9
            game.Roll(10);
            //Strike on frame 10
            game.Roll(10);
            //Strike on extra roll
            game.Roll(10);
            //Strike on extra roll
            game.Roll(10);

            Assert.Equal(300, game.Score());

        }
    }
}
