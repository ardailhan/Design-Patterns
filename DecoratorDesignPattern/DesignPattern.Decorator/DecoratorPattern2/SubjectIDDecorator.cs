using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context c = new();
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageIDSubject(Message message)
        {
            if(message.MessageSubject == "1")
            {
                message.MessageSubject = "Toplantı";
            }
            if(message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Toplantısı";
            }
            if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Haftalık Değerlendirme";
            }
            c.Messages.Add(message);
            c.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}
