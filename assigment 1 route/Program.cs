namespace assigment_1_route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            Book b1 = new Book();
            b1.title = "al haya";
            b1.pages = 100;
            object obj = b1;
            Console.WriteLine(obj);
            #endregion
            #region question2
            Console.WriteLine(b1.ToString());
            Book b2 = b1;
            Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());
            #endregion
        }
    }
}
