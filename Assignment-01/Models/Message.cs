namespace Assignment_01.Models
{
    public class Message
    {
        public readonly string Title;
        public readonly string Content;

        public Message(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}