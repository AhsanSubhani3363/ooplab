using System;
using System.IO;

class BookstoreApp
{
    const int MAX_BOOKS = 100;
    const int MAX_USERS = 10;
    string[,] books = new string[MAX_BOOKS, 3];
    int[,] bookData = new int[MAX_BOOKS, 3];
    bool[] bookExists = new bool[MAX_BOOKS];



    string adminUsername = "ahsan";
    string adminPassword = "123";

    string[,] users = new string[MAX_USERS, 2];


    void ClearConsole()
    {
        Console.Clear();
    }

    void DisplayHeader()
    {
        Console.SetCursorPosition(45, 1);
        Console.WriteLine(".·:''''''''''''''''''''''''''''''''''''''''''''''''''''''''':·.");
        Console.SetCursorPosition(45, 2);
        Console.WriteLine(": :  __        __     _                                     : :");
        Console.SetCursorPosition(45, 3);
        Console.WriteLine(": :  \\ \\      / /___ | |  ___  ___   _ __ ___    ___        : :");
        Console.SetCursorPosition(45, 4);
        Console.WriteLine(": :   \\ \\/\\ / // _ \\| | / __|/ _ \\| '_ ` _ \\ / _ \\       : :");
        Console.SetCursorPosition(45, 5);
        Console.WriteLine(": :    \\ V  V /|  __/| || (__| (_) || | | | | ||  __/       : :");
        Console.SetCursorPosition(45, 6);
        Console.WriteLine(": :     \\_/\\_/  \\___||_| \\___|\\___/ |_| |_| |_| \\___|       : :");
        Console.SetCursorPosition(45, 7);
        Console.WriteLine(": :                        | |_  ___                        : :");
        Console.SetCursorPosition(45, 8);
        Console.WriteLine(": :                        | __|/ _ \\                      : :");
        Console.SetCursorPosition(45, 9);
        Console.WriteLine(": :                        | |_| (_) |                      : :");
        Console.SetCursorPosition(45, 10);
        Console.WriteLine(": :         ____          _ \\__|\\___/                 _     : :");
        Console.SetCursorPosition(45, 11);
        Console.WriteLine(": :        / ___|  _   _ | |__  | |__    __ _  _ __  (_)    : :");
        Console.SetCursorPosition(45, 12);
        Console.WriteLine(": :        \\___ \\ | | | || '_ \\ | '_ \\ / _` || '_ \\ | |    : :");
        Console.SetCursorPosition(45, 13);
        Console.WriteLine(": :         ___) || |_| || |_) || | | || (_| || | | || |    : :");
        Console.SetCursorPosition(45, 14);
        Console.WriteLine(": :        |____/  \\__,_||_.__/ |_| |_| \\__,_||_| |_||_|    : :");
        Console.SetCursorPosition(45, 15);
        Console.WriteLine(": :                                                         : :");
        Console.SetCursorPosition(45, 16);
        Console.WriteLine("'·:.........................................................:·'");
    }

    bool AdminLogin()
    {
        string username, password;
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter admin username: ");
            username = Console.ReadLine();
            Console.Write("Enter admin password: ");
            password = Console.ReadLine();

            if (username == adminUsername && password == adminPassword)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect credentials.");
                attempts++;
            }
        }

        return false;
    }

    bool UserLogin()
    {
        string username, password;
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < MAX_USERS; ++i)
            {
                if (users[i, 0] == username && users[i, 1] == password)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Login Successful!");
                return true;
            }
            else
            {
                Console.WriteLine($"Invalid credentials. You have {--attempts} attempts left.");
            }
        }

        Console.WriteLine("Login failed. Please try again later.");
        return false;
    }


    bool RegisterUser()
    {
        Console.Write("Enter a new Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter a new Password: ");
        string password = Console.ReadLine();

        for (int i = 0; i < MAX_USERS; i++)
        {
            if (string.IsNullOrEmpty(users[i, 0]))
            {
                users[i, 0] = username;
                users[i, 1] = password;

                Console.WriteLine("Registration Successful!");
                return true;
            }
        }

        Console.WriteLine("Registration failed. No space for more users.");
        return false;
    }

    static void Main(string[] args)
    {
        
        {
            BookstoreApp app = new BookstoreApp();

            // Add predefined users for testing
            app.users[0, 0] = "user1";
            app.users[0, 1] = "pass1";
            app.users[1, 0] = "user2";
            app.users[1, 1] = "pass2";

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. User Registration");
                Console.WriteLine("3. User Login");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            if (app.AdminLogin())
                                Console.WriteLine("Admin login successful.");
                            else
                                Console.WriteLine("Admin login failed.");
                            break;
                        case 2:
                            app.RegisterUser();
                            break;
                        case 3:
                            if (app.UserLogin())
                                Console.WriteLine("User login successful.");
                            else
                                Console.WriteLine("User login failed.");
                            break;
                        case 4:
                            Console.WriteLine("Exiting program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
