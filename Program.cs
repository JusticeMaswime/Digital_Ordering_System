using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Ordering_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice;
            bool Option;
            string Complete = "";
            Random random = new Random();
            do
            {
                Console.Clear();
                Order.Display();
                Console.WriteLine("\n1.View our menu.\n2.View our specials.");
                Choice = int.Parse(Console.ReadLine());
                Option = Order.Verify(Choice);

                if(Option)
                {
                    switch(Choice)
                    {
                        case 1:
                            Complete = Order.OrderNow();
                            Option = false;
                            break;
                        case 2:
                            Specials.NoSpecials();
                            
                            break;
                        default:
                            Order.InvalidHandler();
                            break;
                    }
                }
                else
                {
                    Order.InvalidHandler();
                }
            }
            while (Option);
            Console.Clear();
            Order.Display();
            Console.WriteLine(Complete);
            Console.WriteLine("\nYour order number is " + random.Next(0, 1000) + " , ENJOY:) \nPress any key to complete order...");
            Console.ReadKey();
        } 
        
    }

    class Order
    {
        //Order method
        public static string OrderNow()
        {

            int Choice2, Choice3 , quantity;
            bool Option2;
            string Order = "";
            decimal Cost = 0m;
            do
            {
                Console.Clear();
                Display();
                Console.WriteLine("\nSelected your preffered pizza variant:\n1. Chicken variants\n2. Beef variants\n3. Vegeterian variants");
                Choice2 = int.Parse(Console.ReadLine());
                Option2 = Verify(Choice2);
                
                if(Option2)
                {
                    switch(Choice2)
                    {
                        case 1:
                            Console.WriteLine("\nSelected your preffered chicken pizza:\n1. Chicken & Mushrooms\t\t\t95,50\n2. BBQ Chicken\t\t\t\t90,50\n3. Spicy Chicken\t\t\t93,00");
                            Choice3 = int.Parse(Console.ReadLine());
                            if(Verify(Choice3))
                            {
                                switch (Choice3)
                                {
                                    case 1:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Chicken and mushrooms " + Remove() + "\t\t\t\t95,50   x " + quantity + "\n";
                                            Cost += (95.50m * quantity);
                                            Option2 = Another();
                                        }                                                                           
                                        break;
                                    case 2:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "BBQ Chicken " + Remove() + "\t\t\t\t\t90,50  x " + quantity + "\n";
                                            Cost += (90.50m * quantity);
                                            Option2 = Another();
                                        }                                       
                                        break;
                                    case 3:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Spicy chicken " + Remove() + "\t\t\t\t\t93,00 x " + quantity + "\n";
                                            Cost += (93.00m * quantity);
                                            Option2 = Another();
                                        }                                                                           
                                       
                                        break;
                                    default:
                                        InvalidHandler();
                                        break;
                                }
                            }
                            else
                            {
                                InvalidHandler();
                            }
                            break;                 
                        case 2:
                            Console.WriteLine("\nSelected your preffered beef pizza:\n1. Cheesy Beef\t\t\t99,90\n2. Italian Beef & Mushroom\t109,99\n3. Beef & Onion\t\t\t95,00");
                            Choice3 = int.Parse(Console.ReadLine());
                            if (Verify(Choice3))
                            {
                                switch (Choice3)
                                {
                                    case 1:
                                        quantity = Quantity();
                                        if (quantity > 0) 
                                        {
                                            Order += "Cheesy Beef " + Remove() + "\t\t\t\t\t99,90  x " + quantity + "\n";
                                            Cost += (99.90m * quantity);
                                            Option2 = Another();
                                        }                                       
                                        break;
                                    case 2:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Italian Beef & Mushroom " + Remove() + "\t\t\t109,99   x " + quantity + "\n";
                                            Cost += (109.90m * quantity);
                                            Option2 = Another();
                                        }                                      
                                        break;
                                    case 3:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Beef & Onion " + Remove() + "\t\t\t\t\t95,00  x " + quantity + "\n";
                                            Cost += (95.00m * quantity);
                                            Option2 = Another();
                                        }                                                                            
                                        break;
                                    default:
                                        InvalidHandler();
                                        break;
                                }
                            }
                            else
                            {
                                InvalidHandler();
                            }
                            break;
                        case 3:
                            Console.WriteLine("\nSelected your preffered vegeterian pizza:\n1. Roasted Veggie Delight\t\t84,99\n2. Mushroom & Truffle\t\t\t94,99\n3. Indian-style Veggie\t\t\t99,00");
                            Choice3 = int.Parse(Console.ReadLine());
                            if (Verify(Choice3))
                            {
                                switch (Choice3)
                                {
                                    case 1:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Roasted Veggie Delight " + Remove() + "\t\t\t\t84,99  x " + quantity + "\n";
                                            Cost += (84.99m * quantity);
                                            Option2 = Another();
                                        }                                                                             
                                        break;
                                    case 2:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Mushroom & Truffle " + Remove() + "\t\t\t\t94,99  x " + quantity + "\n";
                                            Cost += (94.99m * quantity);
                                            Option2 = Another();
                                        }                                      
                                        break;
                                    case 3:
                                        quantity = Quantity();
                                        if (quantity > 0)
                                        {
                                            Order += "Indian Style Veggie " + Remove() + "\t\t\t\t99,00  x " + quantity + "\n";
                                            Cost += (99.00m * quantity);
                                            Option2 = Another();
                                        }                                                                           
                                        break;
                                    default:
                                        InvalidHandler();
                                        break;
                                }
                            }
                            else
                            {
                                InvalidHandler();
                            }
                            break;
                        default:
                            InvalidHandler();
                            break;
                    }
                }
                else
                {
                    InvalidHandler();
                }
            }
            while (Option2);
            return CompleteOrder(Order, Cost);
        }

        //Validates the user's input
        public static bool Verify(int _Choice)
        {
            if (int.TryParse(_Choice.ToString(), out _Choice))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Allows the user to remove an something from ordered item
        public static string Remove()
        {
            Console.Write("Would you like to remove anything(Y/N)? ");
            if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
            {
                Console.Write("What would you like to remove? ");
                return "without " + Console.ReadLine();
            }
            else
            {
                return "";
            }
        }

        //Allows the user to add another item
        public static bool Another()
        {
            Console.Write("Would you like to add anything else(Y/N)? ");
            if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Gets the number of items requested by user
        static int Quantity()
        {
            int Quant;
            Console.Write("How many of these would you like (enter a number)? ");
            Quant = int.Parse(Console.ReadLine());
            if(Verify(Quant))
            {
                return Quant;
            }
            else
            {
                InvalidHandler();
                return 0;
            }
            
        }

        //Builds the complete order receipt 
        public static string CompleteOrder(string _sOrder, decimal _cost)
        {
            string sComplete = "\n\n Your complete order\n" + _sOrder + "\nThe total cost of your order is " + _cost.ToString("0.00");
            return sComplete;
        }

        public static void Display()
        {
            Console.WriteLine("========================================\n==========SPECIAL-GRADE PIZZA==========\n========================================\n\nWelcome to the home of Pizza");
        }

        //Notifies the user in cases where invalid value is entered
        public static void InvalidHandler()
        {
            Console.WriteLine("You have selected an invalid option, press any key to try again...");
            Console.ReadKey();
        }

    }

    class Specials
    {
        //Notifies the user when no specials are available
        public static void NoSpecials()
        {
            Console.WriteLine("We currently have no specials available :( , try again later.\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
