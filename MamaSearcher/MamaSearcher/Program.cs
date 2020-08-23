using System;

namespace MamaSearcher
{
    class Program
    {

        public static void ActionToPerform(int index, string pattern)
        {
            Console.WriteLine("the pattern : {0} is in the index : {1}", pattern, index);
        }
        static void Main(string[] args)
        {
            Action<int, string> a = ActionToPerform;
            MamaSearcher ms = new MamaSearcher();
            ms.Subscribe("a", a);
            ms.Subscribe("b", a);
            ms.PerformSearch("kjhdb");
        }
    }
}
