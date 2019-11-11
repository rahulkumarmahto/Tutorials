using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternExample
{
    public class MoneyBackCreditCard : CreditCard
    {
        private readonly string cardType;
        private int creditLimit;
        private int annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            cardType = "moneyback";
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override string CardType => cardType;
        public override int CreditLimit { get => creditLimit; set => creditLimit = value; }
        public override int AnnualCharge { get => annualCharge; set => annualCharge = value; }
    }
}
