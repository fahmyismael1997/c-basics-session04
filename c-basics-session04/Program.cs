namespace c_basics_session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print 
              the second price (index 1).*/

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question 2
            /*2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
              shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0. */

            //int[,] shelfCopies = new int[2,2] { {3,5}, {1,4} };
            //Console.WriteLine(shelfCopies[1,0]);

            #endregion

            #region Question 3
            /*Write a method called PrintWelcomeMessage that takes no parameters and prints 
             "Welcome to the Library!". Call it from Main.*/
            // PrintWelcomeMessage();

            #endregion

            #region Question 4
            /*Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with 
             "Clean Code".*/

            //printBookTitle("Clean code");

            #endregion

            #region Question 5
            /*5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable 
              int pages = 400; and print pages afterward. What do you expect to see, and why? */

            //int pages = 400;
            //AddBonusPages(pages);//call by value, we take a copy of pages 

            //Console.WriteLine(pages);//print 400 

            #endregion

            #region Question 6
            /*6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it 
               with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to 
                see, and why?*/


            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);//call by value but Array are Reference type any change is affect at orignal Array
            Console.WriteLine(prices[0]);

            #endregion
        }
        #region ApplyDiscount(double[] prices)
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion

        #region AddBonusPages(int pages)
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}
        #endregion

        #region method PrintBookTitle(string title)
        //static void printBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title: {title}");
        //}


        #endregion




        //method PrintWelcomeMassage
        //static void PrintWelcomeMessage()
        // {
        //     Console.WriteLine("Welcome to the Library!");
        // }





    }
}
