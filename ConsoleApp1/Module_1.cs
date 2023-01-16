namespace ConsoleApp1;

public class Module_1
{
    public static void exercice_1()
    {
        double X;
        string Input;

        System.Console.Write("Entrez un nombre X = ");
        Input = Console.ReadLine();

        try
        {
            X = double.Parse(Input);
            if (X < 0)
                Console.WriteLine("|X| = " + (-X));
            else
                System.Console.WriteLine("|X| = " + X);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error null argument");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error " + Input + " is not a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error " + Input + " is out of rang double value" + "");
        }
    }
};