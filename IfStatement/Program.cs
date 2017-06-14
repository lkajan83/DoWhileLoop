using System;

namespace IfStatement
{
    class Program
    {
        static void Main()
        {


            #region 
            /*
            Console.WriteLine("Please Enter the Number");
            int UserName = int.Parse(Console.ReadLine());
            if (UserName == 1)
            {
                Console.WriteLine("One");
            }

            if(UserName ==  2)
            {
                Console.WriteLine("Two");
            }
            if (UserName == 3)
            {
                Console.WriteLine("Three");
            }
            if(UserName !=1 && UserName !=2 && UserName !=3)
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            } */
            #endregion

            #region
            /*
            while (true)
            {
                Console.WriteLine("Please Enter the Number");
                int UserName = int.Parse(Console.ReadLine());

                if (UserName == 1)
                {
                    Console.WriteLine("One");
                }
                else if (UserName == 2)
                {
                    Console.WriteLine("Two");
                }
                else if (UserName == 3)
                {

                    Console.WriteLine("Three");
                }
                else
                {
                    Console.WriteLine("Your Number is not between 1 and 3");
                }    
            }
            */
            #endregion
            #region
            /*
            while (true)
            {
                Console.WriteLine("Please Enter Number");
                int UserName = int.Parse(Console.ReadLine());
                
                if(UserName ==10 || UserName == 20)
                {
                    Console.WriteLine("User Number 10 or 20");
                }
                else
                {
                    Console.WriteLine("Please check Username  20");
                }
            }
            */
            #endregion

            #region
            while (true)
            {
                Console.WriteLine("Please Enter Number");
                int UserName = int.Parse(Console.ReadLine());

                if (UserName == 10 && UserName == 20)
                {
                    Console.WriteLine("User Number 10 or 20");
                }
                else
                {
                    Console.WriteLine("Not Check");
                }
            }
        
            #endregion


        }
    }
}
