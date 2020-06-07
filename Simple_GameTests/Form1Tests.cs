using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Game.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Game obj = new Game();
            obj.Load();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SHootTest()
        {
            Game obj = new Game();
            obj.Shoot();
            Assert.IsTrue(true);
        }

    }
}