using System;
using System.IO;

namespace Day4
{
    public static class WorkingWithFiles
    {
        public static void FileStuff()
        {
            string path = @"C:\Users\RUQAYAT\Desktop\Software development\Backend\Week 10\Day 2\Day4\Example.pdf";

            if (File.Exists(path))
            {
                // var fc = File.CreateText(path);
                // fc.Dispose();
                using var fc = File.CreateText(path);
            }

           using (var file = File.AppendText(path))
            {
            file.WriteLine("Ruqayat,Agbara,4635737");
            file.WriteLine("Yinka,Lagos,24646647");
            file.Write("Deolu,Lagos,21536236");
            file.Dispose();
            }

            using(StreamReader strmrd = File.OpenText(path))
            {
                var read = strmrd.ReadToEnd();
                read = read.TrimEnd();

                var users = read.Split(Environment.NewLine);

                foreach (var item in users)
                {
                    var user = item.Split(',');
                    System.Console.WriteLine("Name: {0}",user[0]);
                    System.Console.WriteLine("Location: {0}",user[1]);
                    System.Console.WriteLine("Phone: {0}",user[2]);
                    System.Console.WriteLine("------");
                }
            }

            
        }
    }
}