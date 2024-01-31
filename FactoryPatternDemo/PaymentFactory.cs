using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class PaymentFactory
    {
        public static IPayment Create(Constants.PaymentMethod paymentMethod)
        {
            switch(paymentMethod)
            {
                case Constants.PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case Constants.PaymentMethod.Paypal:
                    return new PaypalPayment();
                case Constants.PaymentMethod.Google:
                    return new GooglePayment();
                default:
                    throw new NotSupportedException($"{paymentMethod} is not currently supported as a payment method.");
            }
        }
    }
}
