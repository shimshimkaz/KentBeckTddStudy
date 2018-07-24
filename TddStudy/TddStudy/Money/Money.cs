﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Money
    {
        protected int Amount;

        protected string currency;

        public Money(int amount, string currency)
        {
            Amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, currency);
        }

        public string Currency()
        {
            return currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && currency == money.currency;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amout)
        {
            return new Franc(amout, "CHF");
        }

        public override string ToString()
        {
            return Amount + " " + currency;
        }
    }
}
