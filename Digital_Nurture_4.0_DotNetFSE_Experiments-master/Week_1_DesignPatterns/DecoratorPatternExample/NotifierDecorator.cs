public abstract class NotifierDecorator : INotifier
{
    protected INotifier _notifier;

    public NotifierDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send()
    {
        _notifier.Send();
    }
}
