// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
//VAT method
Console.WriteLine("Assignment 1");
Console.WriteLine("""
                  <<<----->>> Welcome to Café <<<----->>>
                  VAT on music entertainment is 6%
                  VAT on Food is 12%
                  VAT on Alcohol is 25%
                  """);
Console.WriteLine("");
Console.WriteLine("Value-Added-Tax for Music Entertainment is :" + MethodsClass.ValueAddedTax("Music", 30.00) + " kr");
Console.WriteLine("Value-Added-Tax for Food is :" +MethodsClass.ValueAddedTax("Food", 50.00) + " kr");
Console.WriteLine("Value-Added-Tax for Alcohol is :" +MethodsClass.ValueAddedTax("Alcohol", 23.00) + " kr");

