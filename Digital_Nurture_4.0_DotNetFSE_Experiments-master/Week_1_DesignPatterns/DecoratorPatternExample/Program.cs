using System;

class Program
{
    static void Main(string[] args)
    {
        INotifier notifier = new EmailNotifier();

        notifier = new SMSNotifierDecorator(notifier);
        notifier = new SlackNotifierDecorator(notifier);

        notifier.Send();
    }
}
