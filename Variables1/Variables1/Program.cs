public class Class1

{
    static void Main(string[] arg)
    {
        // Primera fase Clasica de primitivos con C# funciona 


       
        int year = 2020;
        long month = 222220015;
        bool visiesto = false;
        float decimales = 2.7f;
        string nombre = "Tipo String";


        Console.WriteLine("Declaración de primitivos en C# especifiacndo el tipo ");
        Console.WriteLine("");
        Console.WriteLine("Variable tipo int " + year);
        Console.WriteLine("Variable tipo long " + month);
        Console.WriteLine("Variable tipo booleano  " + visiesto);
        Console.WriteLine("Variable tipo float " + decimales);
        Console.WriteLine("Variable tipo String  " + nombre);
       



        // Segunda fase Declaración de primitivos en C#

        var year2 = 2021;
        var month2 = 333220015;
        var decimales2 = 1.7f;
        var nombre2 = "Tipo String";
        var visiesto2 = true;

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Segunda fase Declaración de primitivos en C# solo con var sin tipos");
        Console.WriteLine("");
        Console.WriteLine("Variable tipo int " + year2);
        Console.WriteLine("Variable tipo long " + month2);
        Console.WriteLine("Variable tipo booleano  " + visiesto2);
        Console.WriteLine("Variable tipo float " + decimales2);
        Console.WriteLine("Variable tipo String  " + nombre2);


    }




}
