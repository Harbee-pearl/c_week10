using System.Threading;

namespace Day4
{
    public class Threading
    {
        public void MultiThreader()
        {
            Thread thread1 = new Thread(new ThreadStart(Method1));
        }

        public void Method1()
        {
            
        }
    }
}
