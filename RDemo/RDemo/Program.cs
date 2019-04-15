using System;


namespace RDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           var random = new Random();
            const int passwordlength = 10;

            var buffer = new char[passwordlength];
              for (var i=0;i <passwordlength;i++)
              buffer[1] =(char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
