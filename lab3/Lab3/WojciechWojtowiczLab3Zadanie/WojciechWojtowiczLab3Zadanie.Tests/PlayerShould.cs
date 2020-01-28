using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WojciechWojtowiczLab3Zadanie.Tests
{
    public class PlayerShould
    {
        [Fact]
        public void CalculatePlayerMoney()
        {
            Player sut = new Player();

            sut.SetMoney(50);

            Assert.Equals(50, sut.GetMoney());
        }
    }
}
