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
            #region question 3
            // its a compile time eroor 
            // answer:int pages=464;
            #endregion
            #region question4 
            int x = 10;
            int y = 0;
            try
            {
                double div = x / y;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"can not divide by zero ={ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"can not divide by zero ={ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"can not divide by zero ={ex.Message}");
            }
            finally
            { Console.WriteLine("done"); }

            #endregion
            #region question 5
            int pages = 300;
            double doubeledpages = pages;
            Console.WriteLine($"dobleld ={doubeledpages}");
            #endregion
            #region question 6
            double price = 49.99;
            int intprice = (int)price;
            Console.WriteLine(intprice);
            #endregion
            #region question 7
            string pagestext = "464";
            int intpagestext = Convert.ToInt32(pagestext);
            Console.WriteLine(intpagestext);
            #endregion
            #region question 8
            string yeartext = "2023";
            int parsedyear = int.Parse(yeartext);
            Console.WriteLine($"parsedyear={yeartext}");
            string badtext = "abc";
            if (int.TryParse(badtext, out int intbadtext))
            {
                Console.WriteLine($"bad text is parsed ={intbadtext}");
            }
            else
            {
                Console.WriteLine($"bad text is not parsed={badtext}");
            }
            #endregion
            #region question 9
            int pagess = 464;
            string stringpages = Convert.ToString(pagess);
            Console.WriteLine(stringpages);
            Console.WriteLine(stringpages.GetType());
            #endregion
            #region question 10
            int copies = 100;
            object boxedcopies = copies;
            object unboxedcopies = (int)boxedcopies;
            Console.WriteLine(unboxedcopies);

            #endregion


        }
    }
}
