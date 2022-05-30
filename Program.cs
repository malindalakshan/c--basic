using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{

    internal class Program
    {
        static void Main(string[] args)
        {
            person malinda = new person();
            malinda.FullName = "Malinda";
            malinda.LastName = "Lakshan";
            malinda.Introduce();

            Calculater calculater = new Calculater();
            var answer=calculater.Add(1, 2);
            Console.WriteLine(answer);
            

        }
    }
}
