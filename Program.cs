using System;
namespace CsharpBank;

class Program{
        static void Main(){ 

            string returnSwitch = "";
            do{
                Console.WriteLine("CSHARP BANK");
                Console.WriteLine("Login(1) or Create Account?(2)");
                string switchPainel = Console.ReadLine() ?? "";

                switch (switchPainel){
                    case "1": 
                        MyLogin.Login();
                        break;
                    case "2":
                        MyCreateAccount.CreateAccount();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                }

                Console.WriteLine("You want exit?(1)");
                returnSwitch = Console.ReadLine() ?? "";
            } while (returnSwitch != "1");
        }
}
