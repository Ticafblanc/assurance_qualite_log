using System.Runtime.InteropServices;

namespace ConsoleApp1;
using System;

public class Module_1
{
    public static string ReadConsole(string str)
    {
        System.Console.WriteLine(str);
        str = Console.ReadLine();
        return (str);
    }
    /* build a simple calculatrice */
    public static void evaluationFormative2()
    {
        int a;
        int b;
        int Option;
        
        a = int.Parse(ReadConsole("veuiller entrer un entier a"));
        b = int.Parse(ReadConsole("veuiller entrer un entier b"));
        
        System.Console.WriteLine("Choisir une option de la liste suivante:");
        System.Console.WriteLine("\t1 - Addition");
        System.Console.WriteLine("\t2 - Soustraction");
        System.Console.WriteLine("\t3 - Multiplication");
        System.Console.WriteLine("\t4 - Division");
        Option = int.Parse(ReadConsole("Votre otption? "));
        
        System.Console.Write("Le resultat est: ");
        switch (Option)
        {
            case 1:
                System.Console.Write(a + " + " + b + " = " + sous(a,b));
                break;
            case 2:
                System.Console.Write(a + " - " + b + " = " + somme(a,b));
                break;
            case 3:
                System.Console.Write(a + " * " + b + " = " + mult(a,b));
                break;
            case 4:
                System.Console.Write(a + " / " + b + " = " + div(a,b));
                break;
        }
    }
    
    /* Console.WriteLine(getTrinagleSurface(8, 2));
     * Console.WriteLine(getTrinagleSurface(12, 3));*/
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

    /*Compl??tez le code suivant en cr??ant une fonction qui prend deux nombres comme arguments et retourne leur somme*/
    private static int somme(int a, int b)
    {
        return (a + b);
    }
    
    private static int sous(int a, int b)
    {
        return (a - b);
    }
    
    private static int mult(int a, int b)
    {
        return (a * b);
    }

    private static int div(int a, int b)
    {
        return (a / b);
    }
    public static void exercice_2()
    {
        Console.WriteLine(somme(1, 2));
        Console.WriteLine(somme(100, 200));
        Console.WriteLine(somme(-3, -2));

    }

    /* ??crivez une fonction qui prend la base et la hauteur d???un triangle et retourne sa surface. Notez que la
     * surface d???un triangle est: (base * hauteur) / 2*/
    private static int getTrinagleSurface(int a, int b)
    {
        return ((a * b) / 2);
    }

    public static void exercice_3()
    {
        Console.WriteLine(getTrinagleSurface(8, 2));
        Console.WriteLine(getTrinagleSurface(7, 3));
    }

    /* ??crivez un programme C# pour renvoyer le reste de deux nombres. Il existe un seul op??rateur en C#,
     * capable de fournir le reste d???une division. Deux nombres sont transmis comme param??tres.
     * Le premier param??tre divis?? par le deuxi??me param??tre. */

    private static int restDIv(int a, int b)
    {
        return (a % b);
    }

    public static void exercice_4()
    {
        Console.WriteLine(restDIv(1, 3));
        Console.WriteLine(restDIv(2, 4));
        Console.WriteLine(restDIv(3, 3));

    }

    /* Votre t??che consiste ?? cr??er un constructeur Cercle qui cr??e un cercle avec un rayon fourni par un argument.
     * Les cercles construits doivent avoir deux getters GetArea() (PIr ^ 2) et GetPerimeter() (2PI * r) qui donnent 
     * ?? la fois l???aire et le p??rim??tre respectifs */
    class Cercle
    {
        private double R;

        private const double PI = 3.1415926535897931;

        public Cercle(double R)
        {
            this.R = R;
        }

        public double GetArea()
        {
            return (PI * Math.Pow(R, 2));
        }

        public double GetPerimeter()
        {
            return (2 * PI * R);
        }
    }

    public static void exercice_5()
    {
        Cercle C = new Cercle(2);
        System.Console.WriteLine("area = " + C.GetArea());
        System.Console.WriteLine("perimetre = " + C.GetPerimeter());

        Cercle C2 = new Cercle(12);
        System.Console.WriteLine("area = " + C2.GetArea());
        System.Console.WriteLine("perimetre = " + C2.GetPerimeter());

    }

    /*  ??? Cr??ez une classe ?? Person ??
        ??? Cr??ez une classe ?? Student ?? et une autre classe ?? Teacher ??, les deux h??ritent de la classe ?? Person ??.
        ??? La classe ?? Student ?? aura une m??thode publique ?? GoToClasses ??, qui affichera ?? l?????cran ?? Je vais aller 
        ?? ma classe. ??.
        ??? La classe ?? Teacher ?? aura une m??thode publique ?? Explain ??, qui affichera ?? l?????cran ??D??but de l???explication??.
         En plus, il aura un attribut priv?? ?? subject ?? de type string.
        ??? La classe ?? Person ?? doit avoir une m??thode ?? SetAge(int n) ?? qui indiquera la valeur de leur ??ge 
        (par exemple, 15 ans).
        ??? La classe ?? Student ?? aura une m??thode publique ?? DisplayAge ?? qui ??crira sur l?????cran ?? Mon age est : XX ans ??.
        ??? Vous devez cr??er une autre classe de test appel??e ?? Test ?? qui contiendra ?? Main ?? et:
        ??? Cr??ez un objet Person et faites-lui dire ?? Allo ! ??
        ??? Cr??er un objet Student, d??finir son ??ge ?? 15 ans, faites-lui dire ?? Allo ! ??, ?? Je vais aller ?? ma classe. ?? 
        et afficher son ??ge
        ??? Cr??ez un objet Teacher, 40 ans, demandez-lui de dire ?? Allo ! ?? puis commence l???explication. */

    class Person
    {
        protected int age;

        public Person()
        {
            sayAllo();
        }

        public Person(int age)
        {
            sayAllo();
            this.age = age;
        }

        private void sayAllo()
        {
            System.Console.WriteLine("Allo!");
        }

        protected void setAge(int age)
        {
            this.age = age;
        }
    }

    class Student : Person
    {
        public Student() : base(15)
        {
            GoToClasses();
            DisplayAge();
        }

        public void GoToClasses()
        {
            System.Console.WriteLine("Jevais aller a l'ecole");
        }

        public void DisplayAge()
        {
            System.Console.WriteLine("Student is " + age);
        }

        public void setAge(int age)
        {
            base.setAge(age);
        }
    }

    class teacher : Person
    {
        private string subject;

        public teacher() : base(40)
        {
            Explain();
            DisplayAge();
        }

        public void Explain()
        {
            System.Console.WriteLine("Debut de l'explication");
        }

        public void DisplayAge()
        {
            System.Console.WriteLine("teacher is " + age);
        }

        public void setAge(int age)
        {
            base.setAge(age);
        }
    }

    public static void exercice_6()
    {
        Person P = new Person();
        System.Console.WriteLine("");
        Student S = new Student();
        S.setAge(16);
        S.DisplayAge();
        System.Console.WriteLine("");
        teacher T = new teacher();
        T.setAge(41);
        T.DisplayAge();
    }

    /* Ecrire un programme en c# qui permet d'afficher les jours de la semaine (lundi, mardi,...) sachant que les
     jours sont cod??s de 1 ?? 7:
        1----------------->Lundi
        2----------------->Mardi
        ......
        7---------------->Dimanche */
    public static void exercice_7()
    {
        System.Console.Write("quel jours veux tu? : ");
        
        int jour = int.Parse(System.Console.ReadLine());
        switch (jour) 
        {
            case 1:
                Console.WriteLine("1---------->Lundi");
                break;
            case 2:
                Console.WriteLine("2---------->Mardi");
                break;
            case 3:
                Console.WriteLine("3----------->Mercrdi");
                break;
            case 4:
                Console.WriteLine("5----------->Jeudi");
                break;
            case 5:
                Console.WriteLine("6----------->vendredi");
                break;
            case 6:
                Console.WriteLine("7----------->Samedi");
                break;
            case 7:
                Console.WriteLine("8----------->Dimanche");
                break;
        }
        
    }

}