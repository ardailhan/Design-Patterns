using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class CreateNewMessage : ISendMessage
    {
        Context c = new();
        public void SendMessage(Message message)
        {
            c.Messages.Add(message);
            c.SaveChanges();
        }
    }
}
