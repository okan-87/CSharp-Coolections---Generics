using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<String> names = new MyList<String>();
            names.Add("Okan");
            Console.WriteLine(names.Length);
            names.Add("Yigit");
            Console.WriteLine(names.Length);
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
