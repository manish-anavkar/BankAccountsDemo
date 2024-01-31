namespace FactoryPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPayment payment1 = PaymentFactory.Create(Constants.PaymentMethod.CreditCard);
                payment1.Pay(1000);

                IPayment payment2 = PaymentFactory.Create(Constants.PaymentMethod.Paypal);
                payment2.Pay(500);

                IPayment payment3 = PaymentFactory.Create(Constants.PaymentMethod.Google);
                payment3.Pay(750);

                IPayment payment4 = PaymentFactory.Create(Constants.PaymentMethod.Apple);
                payment4.Pay(750);
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
