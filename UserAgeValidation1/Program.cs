// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem, kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muu juhul
//konsoolis kuvatakse "Welcome to Instagram"

using System.ComponentModel.Design;

Console.WriteLine("Enter your age:");

int userAge  = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}
