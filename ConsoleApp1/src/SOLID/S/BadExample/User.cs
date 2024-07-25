

namespace ConsoleApp1.SOLID.S.BadExample
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public void Register()
        {
            // Register user logic
            // ...

            // Send email notification
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome to our platform!", Email);
        }
    }
}