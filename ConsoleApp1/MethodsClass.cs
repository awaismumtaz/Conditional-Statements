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
    
    //Calculating Membership price method

    public static int GymMembershipPrice(int age, bool value)
    {
        var membershipPrice = 0;
        const int premiumPrice = 300;
        
        if ((age <= 19 || age >= 64) && value==false)
        {
            membershipPrice += 2200;
        }
        else if ((age <= 19 || age >= 64) && value)
        {
            membershipPrice += 2200 + premiumPrice;
        }
        else if (value )
        {
            membershipPrice += 3100 + premiumPrice;
        }
        else
        {
            membershipPrice += 3100;
        }

        return membershipPrice;
    }
}