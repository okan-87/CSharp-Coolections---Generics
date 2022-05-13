using System;
using System.Collections.Generic;

namespace Coolections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Okan", "Yigit", "Kagan" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //Arraya sonradan ekleme yapamazsin

            List<string> teams = new List<string> { "Fb","Gs","Bjk","Gb"};
            foreach (var item in teams)
            {
                Console.WriteLine(item);
            }
            teams.Add("SS");
            foreach (var item in teams)
            {
                Console.WriteLine(item);
            }

            
            

           
        }
    }
}
