namespace ConsoleApp1;

public class MethodsClass
{
    //VAT method
    public static double ValueAddedTax(string? product, double price)
    {
        var tax = 0.00;
        switch (product)
        {
            case "Music":
                tax += price * 0.05;
                break;
            case "Food":
                tax += price * 0.12;
                break;
            case "Alcohol":
                tax += price * 0.25;
                break;
        }

        return tax;
    }
}