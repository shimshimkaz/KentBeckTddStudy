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

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && GetType() == money.GetType();
        }
    }
}