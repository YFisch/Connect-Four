using ConnectFourSystem;
using System.Drawing;

namespace ConnectFourTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStartGame()
        {
            Game game = new();
            game.StartGame();
            string msg = $"game status = {game.GameStatus.ToString()} current turn = {game.CurrentTurn.ToString()} num tokens = {game.Tokens.Count} num enter buttons = {game.EnterButtons.Count}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Playing && game.CurrentTurn == Game.TurnEnum.Red && game.Tokens.Count == 42 && game.EnterButtons.Count == 7, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void GetColumn()
        {
            Game game = new();
            game.StartGame();
            game.GetColumn(0);
            string msg = $"token 35 = {game.Tokens[35].BackColor.ToString()} current turn = {game.CurrentTurn.ToString()}";
            Assert.IsTrue(game.Tokens[35].BackColor == Color.Red && game.CurrentTurn == Game.TurnEnum.Yellow, msg);
            TestContext.WriteLine(msg);
        }
        [TestCase(0, 1, 0, 1, 0, 1, 0)]
        [TestCase(2, 1, 3, 1, 4, 1, 5)]
        public void TestWinner(int r0, int y0, int r1, int y1, int r2, int y2, int r3)
        {
            Game game = new();
            game.StartGame();
            game.GetColumn(r0);
            game.GetColumn(y0);
            game.GetColumn(r1);
            game.GetColumn(y1);
            game.GetColumn(r2);
            game.GetColumn(y2);
            game.GetColumn(r3);
            string msg = $"game state = {game.GameStatus} winner is {game.Winner.ToString()}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Winner && game.Winner == Game.TurnEnum.Red, msg);
            TestContext.WriteLine(msg);
        }

        [Test]

        public void TestTie()
        {
            Game game = new();
            game.StartGame();
            game.GetColumn(0); 
            game.GetColumn(0); 
            game.GetColumn(0); 
            game.GetColumn(0); 
            game.GetColumn(0); 
            game.GetColumn(0); 
            game.GetColumn(1); 
            game.GetColumn(1); 
            game.GetColumn(1);
            game.GetColumn(1);
            game.GetColumn(1);
            game.GetColumn(1);
            game.GetColumn(2);
            game.GetColumn(2);
            game.GetColumn(2);
            game.GetColumn(2);
            game.GetColumn(2);
            game.GetColumn(2);
            game.GetColumn(4);
            game.GetColumn(4);
            game.GetColumn(4);
            game.GetColumn(4);
            game.GetColumn(4);
            game.GetColumn(4);
            game.GetColumn(5);
            game.GetColumn(3);
            game.GetColumn(3);
            game.GetColumn(3);
            game.GetColumn(3);
            game.GetColumn(3);
            game.GetColumn(3);
            game.GetColumn(6);
            game.GetColumn(6);
            game.GetColumn(6);
            game.GetColumn(6);
            game.GetColumn(6);
            game.GetColumn(6);
            game.GetColumn(5);
            game.GetColumn(5);
            game.GetColumn(5);
            game.GetColumn(5);
            game.GetColumn(5);
            string msg = $"game state = {game.GameStatus} winner is {game.Winner.ToString()}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Tie, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestPlayComputer()
        {
            Game game = new();
            game.StartGame(true);
            game.GetColumn(4);
            bool b = game.Tokens.Exists(t => t.BackColor == Color.Yellow);
            string msg = $"computer took turn = {b.ToString()} current turn = {game.CurrentTurn.ToString()}";
            Assert.IsTrue(b == true && game.CurrentTurn == Game.TurnEnum.Red, msg);
            TestContext.WriteLine(msg);
        }
    }
}