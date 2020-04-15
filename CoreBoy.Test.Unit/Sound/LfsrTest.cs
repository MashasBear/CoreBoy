﻿using CoreBoy.sound;
using NUnit.Framework;

namespace CoreBoy.Test.Unit.Sound
{
    [TestFixture]
    public class LfsrTest
    {

        [Test]
        public void testLfsr()
        {
            Lfsr lfsr = new Lfsr();
            int previousValue = 0;
            for (int i = 0; i < 100; i++)
            {
                lfsr.nextBit(false);
                Assert.AreNotEqual(previousValue, lfsr.getValue());
                previousValue = lfsr.getValue();
            }
        }

        [Test]
        public void testLfsrWidth7()
        {
            Lfsr lfsr = new Lfsr();
            int previousValue = 0;
            for (int i = 0; i < 100; i++)
            {
                lfsr.nextBit(true);
                Assert.AreNotEqual(previousValue, lfsr.getValue());
                previousValue = lfsr.getValue();
            }
        }
    }
}