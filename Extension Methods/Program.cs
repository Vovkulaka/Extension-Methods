namespace Extension_Methods
{
    internal class Program
    {
        static private int resultInnerMethod = 0;
        static private int resultExtentionMethod = 0;
        static void Main(string[] args)
        {
            BaseClass baseClass = new();
            //ExtantionStaticClass baseClass0 = new(); - не можливо створити екземпляр статичного класу!

            resultInnerMethod = baseClass.A_plus_B();
            resultExtentionMethod = baseClass.ExtentionMethod_A_multiply_AA();   

            Console.WriteLine("resultInnerMethod = {0}", resultInnerMethod);
            Console.WriteLine("resultExtentionMethod = {0}", resultExtentionMethod);
        }
    }
}