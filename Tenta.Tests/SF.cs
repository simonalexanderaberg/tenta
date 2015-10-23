using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenta.Lib;

namespace Tenta.Tests
{
    [TestClass]
    public class SF
    {
        [TestMethod]
        public void CreateFacadeAndIPlayer()
        {
            PlayerFactory factory = new PlayerFactory();
            IPlayer player = factory.CreatePlayer("SF");
            MovieFacade facade = new MovieFacade(player);
            facade.Play("Bad Boys");
            Assert.IsNotNull(player);
            Assert.IsNotNull(facade);
        }
    }
}
