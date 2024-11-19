// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Assignment # 1
Console.WriteLine("Assignment 1");
Console.WriteLine("""
                  <<<----->>> Welcome to Café <<<----->>>
                  VAT on music entertainment is 6%
                  VAT on Food is 12%
                  VAT on Alcohol is 25%
                  """);
Console.WriteLine("");

//Test Cases
Console.WriteLine("Value-Added-Tax for Music Entertainment is :" + MethodsClass.ValueAddedTax("Music", 30.00) + " kr");
Console.WriteLine("Value-Added-Tax for Food is :" +MethodsClass.ValueAddedTax("Food", 50.00) + " kr");
Console.WriteLine("Value-Added-Tax for Alcohol is :" +MethodsClass.ValueAddedTax("Alcohol", 23.00) + " kr");

//Assignment # 2

Console.WriteLine("------------------------------------------");
Console.WriteLine("Assignment 2");
Console.WriteLine("");

//Test cases
Console.WriteLine("Age <= 19 and Don't want Premium : " + MethodsClass.GymMembershipPrice(17, false));
Console.WriteLine("Age <= 19 and want Premium : " + MethodsClass.GymMembershipPrice(17, true));
Console.WriteLine("");
Console.WriteLine("Age >= 64 and Don't want Premium : " + MethodsClass.GymMembershipPrice(65, false));
Console.WriteLine("Age >= 64 and want Premium : " + MethodsClass.GymMembershipPrice(65, true));
Console.WriteLine("");
Console.WriteLine("All other customers >19 and < 64 and Don't want Premium : " + MethodsClass.GymMembershipPrice(30, false));
Console.WriteLine("All other customers >19 and < 64 and want Premium : " + MethodsClass.GymMembershipPrice(30, true));






