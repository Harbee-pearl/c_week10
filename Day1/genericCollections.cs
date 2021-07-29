using System;
using System.Collections.Generic;

namespace Day1
{
    public class genericCollections
    {
        public static void Fee<T>(T value)
        {
            System.Console.WriteLine(value);
        }

        public static void Dictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Kunle");
            dict.Add(2, "Deolu");
            dict.Add(3, "Adeolu");

            var val = dict[2];
            System.Console.WriteLine(val);

        }

        public static void HashSet()
        {
            HashSet<int> hashset = new HashSet<int>();
            HashSet<int> hashset2 = new HashSet<int>();
            HashSet<string> hashset3 = new HashSet<string>();

            hashset.Add(1);
            hashset.Add(2);
            hashset.Add(3);
            hashset.Add(4);

            hashset2.Add(2);
            hashset2.Add(3);
            hashset2.Add(7);
            hashset2.Add(8);

            hashset3.Add("Monday");
            hashset3.Add("TUESDAY");
            hashset3.Add("Tuesday");

            // hashset.ExceptWith(hashset2);
            // hashset.IntersectWith(hashset2);

            System.Console.WriteLine(hashset3.Count);
        }

        public static void SortedSet()
        {
            SortedSet<int> sset = new SortedSet<int>();

            sset.Add(14);
            sset.Add(2);
            sset.Add(39);
            sset.Add(18);
            var ReverseSet = sset.Reverse();
            foreach (var item in ReverseSet)
            {
                System.Console.WriteLine(item);
            }
        }

        public static void Tuples()
        {
            // How to create tuples
            // Tuples cannot take more than 8 values
            Tuple<int, int, string, string, int> tuple = new Tuple<int, int, string, string, int>(2, 2,"Bae", "Boo", 9);

            var Tuple2 = Tuple.Create<int, string, int>(2, "bae", 4);
        }

        public static bool UniqueChecker(int a, int b, int c, int d)
        {
            HashSet<int> checker = new HashSet<int>();
            checker.Add(a);
            checker.Add(b);
            checker.Add(c);
            checker.Add(d);

            // foreach (var item in checker)
            // {
            //     System.Console.WriteLine(item);
            // }
            if(checker.Count == 4)
            {
                bool isUnique = true;
                System.Console.WriteLine("The values are unique");
                return isUnique;
            } else
            {
                bool isUnique = false;
                System.Console.WriteLine("The values are not unique");
                return isUnique;
            }
        }
    }
}