using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
    public class MoneyBackCreditCardFactory : CreditCardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public MoneyBackCreditCardFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(creditLimit, annualCharge);
        }
    }
}
