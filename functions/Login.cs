using System;
using System.Text.Json;

namespace CsharpBank;

class MyLogin{
    public static void Login(){
        Console.WriteLine("");
        Console.WriteLine("Username: ");
        string username = Console.ReadLine() ?? "";
        Console.WriteLine("Password: ");
        string password = Console.ReadLine() ?? "";

        if (IsValidCredentials(username, password)){
                Console.WriteLine("Login successful!");
        }
        else{
            Console.WriteLine("Invalid username or password. Please try again.");
        }

    }
    private static bool IsValidCredentials(string username, string password){
            string fileName = "data/user.json";
            string jsonContent = File.ReadAllText(fileName);

            User storedUser = JsonSerializer.Deserialize<User>(jsonContent);

            return storedUser != null && storedUser.Username == username && storedUser.Password == password;
        
    }
}