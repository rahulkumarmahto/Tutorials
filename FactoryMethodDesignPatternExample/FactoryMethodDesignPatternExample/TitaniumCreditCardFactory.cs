using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
    public class TitaniumCreditCardFactory: CreditCardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public TitaniumCreditCardFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(creditLimit, annualCharge);
        }
    }
}
