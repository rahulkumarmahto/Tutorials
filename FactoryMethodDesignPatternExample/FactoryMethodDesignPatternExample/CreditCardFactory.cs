using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
    public abstract class CreditCardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
