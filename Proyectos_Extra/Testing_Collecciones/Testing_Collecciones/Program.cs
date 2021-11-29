using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Testing_Collecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            /*
            Console.WriteLine("List:");

            Testing p1 = new Testing("Ezequiel", "Hombre", 20);
            Testing p2 = new Testing("Rocio", "Mujer", 19);
            Testing p3 = new Testing("Pedro", "Hombre", 22);

            List<Testing> testings = new List<Testing>();
            testings.Add(p1);
            testings.Add(p2);
            testings.Add(p3);

            foreach (Testing item in testings) 
            {
                Console.WriteLine(item.ShowPeople());
            }
            testings.Remove(p3);

            foreach (Testing item in testings)
            {
                Console.WriteLine(item.ShowPeople());
            }
            */
            #endregion

            #region Dictionary
            /*
            Console.WriteLine("\nDictionary: \n");

            Dictionary<string, string> book = new Dictionary<string, string>();
            book.Add("People", "Mujer");
            book.Add("Add", "Agregar");
            book.Add("Remove", "Remover");

            Console.WriteLine(book["People"]);
            Console.WriteLine(book["Add"]);
            Console.WriteLine(book["Remove"]);


            foreach (KeyValuePair<string, string> item in book) 
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            Testing superEntidades = new Testing();
            superEntidades += 3;
            superEntidades += 3;
            superEntidades += 1;
            Console.WriteLine(superEntidades.Resultado);



        }
    }
}
