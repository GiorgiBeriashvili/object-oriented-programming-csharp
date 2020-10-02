# Usage

Sample usage scenario after running the `dotnet run` command:

```plaintext
Choose the message recipient from the user list below:
1 - Giorgi Beriashvili
2 - Other...

Enter the recipient user's index (1-2): 2

Enter user's first name: John
Enter user's last name: Doe
Enter user's address: Unknown

Successfully inferred user - `John Doe`!

Enter message's title: Regarding Last Sunday...
Enter message's content: Lorem ipsum dolor sit amet.

Successfully inferred message titled as `Regarding Last Sunday...`!

Sending message to user #2...

Message received:

Title: Regarding Last Sunday...

Content: Lorem ipsum dolor sit amet.

Would you like to send another message? (Y/n): y

Choose the message recipient from the user list below:
1 - Giorgi Beriashvili
2 - John Doe
3 - Other...

Enter the recipient user's index (1-3): 3

Enter user's first name: Jane
Enter user's last name: Doe
Enter user's address: Unknown

Successfully inferred user - `Jane Doe`!

Enter message's title: Consectetur Adipiscing Elit
Enter message's content: Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

Successfully inferred message titled as `Consectetur Adipiscing Elit`!

Sending message to user #3...

Message received:

Title: Consectetur Adipiscing Elit

Content: Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

Would you like to send another message? (Y/n): n
```
