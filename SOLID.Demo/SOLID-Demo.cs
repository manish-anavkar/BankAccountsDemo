using system;

namespace SOLID.Demo
{
    public class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly IOrderSaver[] orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        public OrderProcessor(OrderValidator orderValidator, IOrderSaver[] orderSaver, OrderNotificationSender orderNotificationSender)
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }

        public void Process()
        {
            orderValidator.Validate();
            foreach (var item in orderSaver)
            {
                item.Save();
            }
            orderNotificationSender.SendNotification();
        }
        
    }

    public class OrderValidator()
    {
        // Validate
        public void Validate() {};
    }

    public interface IOrderSaver
    {
        void Save(string order);
    }

    public class DBOrderSaver() : IOrderSaver
    {
        // Save
        public void Save(string order) {};
    }

    public class CacheOrderSaver : IOrderSaver
    {
        // Save
        public void Save(string order) {};
    }

    public class OrderNotificationSender()
    {
        // Notification
        public void SendNotification() {};
    }
}
