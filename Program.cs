using System;

namespace DelegatesBeDelegating
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = new PresidentialAction() { ActionName = "Sign a treaty." };
            var delegateAction = new Diplomacy(); // publisher
            var messageService = new MessageService(); // subscriber

            delegateAction.Decreed += messageService.SendDecree;
            delegateAction.SendPresidentialMessage(action);

        }
    }

    public class MessageService
    {
        public void SendDecree(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending the Presidential decree...");
        }
    }
}
