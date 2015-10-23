using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenta.Lib;

namespace Tenta.Tests
{
    /// <summary>
    /// Summary description for Netflix
    /// </summary>
    [TestClass]
    public class Netflix
    {
        [TestMethod]
        public void CreateFacadeAndIPlayer()
        {
            PlayerFactory factory = new PlayerFactory();
            IPlayer player = factory.CreatePlayer("Netflix");
            MovieFacade facade = new MovieFacade(player);
            facade.Play("Bad Boys");
            Assert.IsNotNull(player);
            Assert.IsNotNull(facade);
        }
    }
}
