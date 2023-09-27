using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        Context c = new();
        private readonly INotifier _notifier;
        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }
        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "Gmail-Outlook";
            notifier.NotifierType = "Private Team";

            c.Notifiers.Add(notifier);
            c.SaveChanges();
        }
        public override void CreateNotifier(Notifier notifier)
        {
            base.CreateNotifier(notifier);
            SendMailNotify(notifier);
        }
    }
}
