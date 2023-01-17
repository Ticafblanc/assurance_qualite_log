using ConsoleApp1;

class Program
{
    class ApplicationValAbsolue1
    {
        static void Launch_exercice()
        {
            int exercise = int.Parse(Module_1.ReadConsole("enter the number of exercices 1 - 7\n" +
                                                          "or 8 for the formative evaluation  : "));
            switch (exercise)
            {
                case 1:
                    Module_1.exercice_1();
                    break;
                case 2:
                    Module_1.exercice_2();
                    break;
                case 3:
                    Module_1.exercice_3();
                    break;
                case 4:
                    Module_1.exercice_4();
                    break;
                case 5:
                    Module_1.exercice_5();
                    break;
                case 6:
                    Module_1.exercice_6();
                    break;
                case 7:
                    Module_1.exercice_7();
                    break;
                case 8:
                    Module_1.evaluationFormative2();
                    break;
                default:
                    System.Console.WriteLine("error exercice only 1 - 7 or 8 for the formative evaluation !!");
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                Launch_exercice();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error null argument");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error is not a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error is out of rang double value" );
            }
        }

    }
    
}
