using System.Collections;

namespace Day1
{
    public class practingCollections
    {
        public static void CreatingArray()
        {
            int[] arr = new int[3];
            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
        
        public static void CreatingArrayList()
        {
            ArrayList arrli = new ArrayList();
            arrli.Add(3);
            arrli.Add(5);
        }

        public static void HashTable()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(5, "well");
            hashtable.Add('A', "well");
            hashtable.Add(8, 'A');

            var welp = hashtable[1];
            System.Console.WriteLine(welp);

        }
    }
}