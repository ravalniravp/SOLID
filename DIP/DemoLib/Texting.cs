namespace DemoLib
{
    public class Texting : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"I am texting {owner.FirstName} to say {message}");
        }
    }
}