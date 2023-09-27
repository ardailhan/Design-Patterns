using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context c = new();
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptoSubject(Message message)
        {
            //message.MessageSender = "İnsan Kaynakları";
            //message.MessageReceiver = "Yazılım Ekibi";
            //message.MessageContent = "Saat 12:00'de Toplantı Var";
            //message.MessageSubject = "Toplantı";
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }
            c.Messages.Add(message);
            c.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
