using System;

namespace FactoryMethodDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string cardType = Console.ReadLine();

            switch (cardType.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackCreditCardFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumCreditCardFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlantinumCreditCardFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("Information about the card: ");

            Console.WriteLine($"Card type: {creditCard.CardType}, Credit Limit: {creditCard.CreditLimit}, Annual Charge: {creditCard.AnnualCharge}");
            Console.ReadLine();
        }
    }
}
