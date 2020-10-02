using Assignment_01.Utilities;

namespace Assignment_01.Models
{
    public class User
    {
        private static int _id = 0;

        public int Id { get; }
        public string FirstName;
        public string LastName;
        public string Address;

        public User(string firstName, string lastName, string address)
        {
            Id = ++_id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public void GetMessage(Message message) => UserInterface.PrintLine($"Message received:\n\nTitle: {message.Title}\n\nContent: {message.Content}");
    }
}