using System;
using System.Text.Json;

namespace CsharpBank;

class MyCreateAccount{
    public static void CreateAccount(){
        Console.WriteLine("");
        Console.WriteLine("Username: ");
        string username = Console.ReadLine() ?? "";
        Console.WriteLine("E-mail: ");
        string email = Console.ReadLine() ?? "";
        Console.WriteLine("Password: ");
        string password = Console.ReadLine() ?? "";
        Console.WriteLine("Confirm Password: ");
        string confirmPassword = Console.ReadLine() ?? "";

            if (password != confirmPassword){
                Console.WriteLine("Passwords do not match. Account creation failed.");
                return;
            }

            User newUser = new User(username, email, password);

            string json = JsonSerializer.Serialize(newUser);

            string fileName = "data/user.json";
            File.WriteAllText(fileName, json);

            Console.WriteLine("Account created and data saved to users.json.");
    }
}