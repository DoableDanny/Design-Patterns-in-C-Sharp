namespace ConsoleApp1.Coupling
{
  public class EmailSender : INotificationService
  {
    public void SendNotification(string message)
    {
      // Email sending logic
      Console.WriteLine("Sending email: " + message);
    }
  }
}