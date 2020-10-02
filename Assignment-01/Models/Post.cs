namespace Assignment_01.Models
{
    public static class Post
    {
        public static void SendMessageToUser(User user, Message message) => user.GetMessage(message);
    }
}