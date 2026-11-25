using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print
            //the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0
            //int[,] shelfCopies = new int[2, 2]
            //{
            //    {3,5},
            //    {1,4}
            //};
            //Console.WriteLine(shelfCopies[1, 0]);



            #endregion

            #region Question3

            //{
            //    Program.PrintWelcomeMessage();
            //}
            #endregion
            #region Question4
            //Program.PrintBookTitle("Clean Code");
            #endregion


            #region Question5
            //int Pages = 400;
            //Console.WriteLine(Pages);
            //AddBonusPages(Pages);
            //Console.WriteLine(Pages);





            #endregion



            #region Question6
            //The output will be 20.5 because an Array is a Reference Type. The reference is copied, not the array itself. 

            //Both references point to the same array in memory. Therefore, any changes made to the array elements inside the method will affect the original array.
            
            double[] prices = { 25.5, 40.0 };

            ApplyDiscount(prices);

            Console.WriteLine(prices[0]);
            #endregion






        }


        #region Question3
        //Write a method called PrintWelcomeMessage that takes no parameters and prints
        //"Welcome to the Library!". Call it from Main.

        //public static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion

        #region Question4
        //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
        //"Clean Code"

        //public static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: "+title);
        //}


        #endregion


        #region Question5
        //public static void AddBonusPages(int Pages)
        //{
        //    Pages += 50;


        //}
        //The result will be 400 because this is Pass by Value It takes a copy of the variable's value not the original
        //variable It changes the copy it receives not the original value This is different  ref

        #endregion

        #region Question6
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion







    }
}
