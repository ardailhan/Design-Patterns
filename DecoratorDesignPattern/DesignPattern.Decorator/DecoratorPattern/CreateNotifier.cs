using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class CreateNotifier : INotifier
    {
        Context c = new();
        void INotifier.CreateNotifier(Notifier notifier)
        {
            c.Notifiers.Add(notifier);
            c.SaveChanges();
        }
    }
}
