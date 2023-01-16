using System.Runtime.InteropServices;

namespace ConsoleApp1;
using System;

public class Module_1
{
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

    /*Complétez le code suivant en créant une fonction qui prend deux nombres comme arguments et retourne leur somme*/
    private static int somme(int a, int b)
    {
        return (a + b);
    }

    public static void exercice_2()
    {
        Console.WriteLine(somme(1, 2));
        Console.WriteLine(somme(100, 200));
        Console.WriteLine(somme(-3, -2));

    }

    /* Écrivez une fonction qui prend la base et la hauteur d’un triangle et retourne sa surface. Notez que la
     * surface d’un triangle est: (base * hauteur) / 2*/
    private static int getTrinagleSurface(int a, int b)
    {
        return ((a * b) / 2);
    }

    public static void exercice_3()
    {
        Console.WriteLine(getTrinagleSurface(8, 2));
        Console.WriteLine(getTrinagleSurface(7, 3));
    }

    /* Écrivez un programme C# pour renvoyer le reste de deux nombres. Il existe un seul opérateur en C#,
     * capable de fournir le reste d’une division. Deux nombres sont transmis comme paramètres.
     * Le premier paramètre divisé par le deuxième paramètre. */

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

    /* Votre tâche consiste à créer un constructeur Cercle qui crée un cercle avec un rayon fourni par un argument.
     * Les cercles construits doivent avoir deux getters GetArea() (PIr ^ 2) et GetPerimeter() (2PI * r) qui donnent 
     * à la fois l’aire et le périmètre respectifs */
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

    /*  – Créez une classe « Person »
        – Créez une classe « Student » et une autre classe « Teacher », les deux héritent de la classe « Person ».
        – La classe « Student » aura une méthode publique « GoToClasses », qui affichera à l’écran « Je vais aller à ma classe. ».
        – La classe « Teacher » aura une méthode publique « Explain », qui affichera à l’écran «Début de l’explication». En plus, il aura un attribut privé « subject » de type string.
        – La classe « Person » doit avoir une méthode « SetAge(int n) » qui indiquera la valeur de leur âge (par exemple, 15 ans).
        – La classe « Student » aura une méthode publique « DisplayAge » qui écrira sur l’écran « Mon age est : XX ans ».
        – Vous devez créer une autre classe de test appelée « Test » qui contiendra « Main » et:
        – Créez un objet Person et faites-lui dire « Allo ! »
        – Créer un objet Student, définir son âge à 15 ans, faites-lui dire « Allo ! », « Je vais aller à ma classe. » et afficher son âge
        – Créez un objet Teacher, 40 ans, demandez-lui de dire « Allo ! » puis commence l’explication. */

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

    /* Ecrire un programme en c# qui permet d'afficher les jours de la semaine (lundi, mardi,...) sachant que les jours sont codés de 1 à 7:
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