using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WojciechWojtowiczLab3Zadanie.Tests
{
    public class PlayerShould
    {
        /// <summary>
        /// test do sprawdzenia czy ustawiony parametr jest równy pobranemu
        /// </summary>
        [Fact]
        public void CalculatePlayerMoney()
        {
            Player sut = new Player();

            sut.SetMoney(50);

            Assert.Equal(50, sut.GetMoney());
        }

        /// <summary>
        /// test do sprawdzenia czy ustawiony parametr jest różny jakiegoś innego
        /// </summary>
        [Fact]
        public void CalculatePlayerMoney2()
        {
            Player sut = new Player();

            sut.SetMoney(50);

            Assert.NotEqual(100, sut.GetMoney());
        }

        /// <summary>
        ///  test do sprawdzenia czy ustawiony parametr jest równy pobranemu
        /// </summary>
        [Fact]
        public void CalculatePlayerHonor()
        {
            Player sut = new Player();

            sut.SetHonor(100);

            Assert.Equal(100, sut.GetHonor());
        }

        /// <summary>
        /// test do sprawdzenia czy ustawiony parametr jest różny od jakiegoś innego
        /// </summary>
        [Fact]
        public void CalculatePlayerHonor2()
        {
            Player sut = new Player();

            sut.SetHonor(100);

            Assert.NotEqual(123, sut.GetHonor());
        }
    }
}
