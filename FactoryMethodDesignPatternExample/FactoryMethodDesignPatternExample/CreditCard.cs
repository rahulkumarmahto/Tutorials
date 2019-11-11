﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
   public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
