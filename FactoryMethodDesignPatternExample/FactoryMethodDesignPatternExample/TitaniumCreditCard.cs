using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string cardType;
        private int creditLimit;
        private int annualLimit;

        public TitaniumCreditCard(int creditLimit, int annualLimit)
        {
            cardType = "titanium";
            this.creditLimit = creditLimit;
            this.annualLimit = annualLimit;
        }

        public override string CardType => cardType;
        public override int CreditLimit { get => creditLimit; set => creditLimit = value; }
        public override int AnnualCharge { get => annualLimit; set => annualLimit = value; }
    }
}
