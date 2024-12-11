using System.Security.Cryptography;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Number 1
            // int X = 5;
            //  Console.WriteLine("Enter A Number :  ");
            //  Console.ReadLine();
            #endregion
            #region Number 2
            //  int X = 8;
            //  int Y = X;
            //   Console.WriteLine(X);
            //  Console.WriteLine(Y);       // X will be 8 and y will be 8 also .


            //  int X = 7;
            //  Console.WriteLine(X);    // X will be 7.
            #endregion
            #region Number 3

            Point P1;
            P1 = new Point();

            Point P2 = new Point();       // now this is unreachable 
            P2 = P1;

            P1.x = 9;
            Console.WriteLine(P2.x);          // they both now assign to same address 
            Console.WriteLine(P1.x);          // The same Result
            #endregion
        }
    }
}
