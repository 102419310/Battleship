using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void hit()
        {
        BattleShipsGame game = new BattleShipsGame();
        Player p1 = new Player(game);
        try { p1.PlayerGrid.MoveShip(0, 0, ShipName.Battleship, Direction.LeftRight); } catch (Exception e) { }
        AttackResult result = p1.PlayerGrid.HitTile(0, 0);
        Assert.AreEqual("hit something!", result.Text);
    }
    [TestMethod]
    public void missed()
    {
        BattleShipsGame game = new BattleShipsGame();
        Player p1 = new Player(game);
        try { p1.PlayerGrid.MoveShip(0, 0, ShipName.Battleship, Direction.LeftRight); } catch (Exception e) { }
        AttackResult result = p1.PlayerGrid.HitTile(8, 8);
        Assert.AreEqual("missed", result.Text);
    }
}

