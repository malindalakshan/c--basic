namespace CSharpFundamentals
{
    public class person{
        public String FullName;
        public String LastName;

        public void Introduce()
        {
            Console.WriteLine("My full name is"+" " + FullName + " " + LastName);
        }
    }
}
