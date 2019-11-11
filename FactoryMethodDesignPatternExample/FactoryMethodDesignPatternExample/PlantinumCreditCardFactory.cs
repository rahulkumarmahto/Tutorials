using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
    public class PlantinumCreditCardFactory: CreditCardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public PlantinumCreditCardFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(creditLimit, annualCharge);
        }
    }
}
