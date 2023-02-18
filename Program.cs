using System;
using KESCHA.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Animal kescha = new Bird(name: "Kescha", animalAge: 4);
        Animal kasee = new Pet(name: "Kasee", animalAge: 4);
        System.Console.WriteLine("Bu aynan men ko'rgan vaqt:\t" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));


        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Kescha says: ");
        kescha.Greet(userName);
        Console.WriteLine("Kasee says: ");
        kasee.Greet(userName);

        System.Console.Write("Enter you age: ");
        string ageAsString = Console.ReadLine();

        System.Console.WriteLine("Converting...");
        int userAge = Convert.ToInt32(ageAsString);
        System.Console.WriteLine($"Successfuly converted! {userAge}");


        Console.WriteLine($"Barakalla {userName} siz {2023 - userAge}-yilda tug'ilgansiz!");

        kescha.CalculateAgeDifferenceNoReturn(userAge);
        kescha.PrintAgeDifference();
        kescha.CompareAges(userAge);
        kescha.KommissionAges();
        kescha.TellAbautFriend(userName, userAge);


    }
}