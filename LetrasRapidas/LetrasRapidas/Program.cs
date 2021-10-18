using System;
using System.Collections.Generic;

namespace LetrasRapidas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4.2
            // FASE 1

            char[] Myname = { 'P', 'E', 'd', 'r', 'o' };
            string Myname2 = null;

            for (int i = 0; i < Myname.Length; i++)
            {

                Console.WriteLine(Myname[i] + "\n");

                Myname2 = Myname2 + Myname[i];

            }
            Console.WriteLine("Array  del nombre Char\n");
            Console.WriteLine("El nombre to seguido es " + Myname2);


            // FASE 2

            List<string> MynameList = new List<string>();

            MynameList.Add("P");
            MynameList.Add("e");
            MynameList.Add("d");
            MynameList.Add("r");
            MynameList.Add("o");

            Console.WriteLine("\nList del Nombre\n");
            MynameList.ForEach(Console.WriteLine);

            /*
            // Model con el Array que funciona 

            char letra;

            for (int i = 0; i < Myname.Length; i++)
            {

                letra = Myname[i];

                int vocal = char.ToLower(letra);

                if ((vocal == 'a') | (vocal == 'e') | (vocal == 'i') | (vocal == 'o') | (vocal == 'u') | (vocal == 'A') | (vocal == 'E') | (vocal == 'I') | (vocal == 'O') | (vocal == 'U'))
                {

                    Console.WriteLine("La letra " + Myname[i] + " es una VOCAL");
                }
                else
                {
                    Console.WriteLine("La letra " + Myname[i] + " es una CONSONANTE");
                }
            }*/
        }
    }
}
