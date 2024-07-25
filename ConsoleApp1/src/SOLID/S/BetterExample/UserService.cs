

namespace ConsoleApp1.SOLID.S.BetterExample
{
    public class UserService
    {
        public void RegisterUser(User user)
        {
            // Register user logic
            // ...

            // Optionally, notify user via email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome to our platform!", user.Email);
        }
    }
}