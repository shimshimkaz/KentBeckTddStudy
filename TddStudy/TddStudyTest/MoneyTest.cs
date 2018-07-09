﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddStudy.Money;

namespace TddStudyTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
            Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }
    }
}
