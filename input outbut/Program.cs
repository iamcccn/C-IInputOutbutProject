using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_outbut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                                                                 @CopyRight:iamc4 ");
           Console.WriteLine("WelCome To input Outbut app");
            Console.WriteLine(" ");
            Console.WriteLine("1.Get Start App ");
            Console.WriteLine("2.EXIT App ");

            string GetStartOrExit;
            GetStartOrExit = Console.ReadLine();
            switch (GetStartOrExit)
            {
                case "1":
                    GetsartApp(); ;
                    break;
                case "2":
                    ExitApp();
                    break;
            }
        }
        static void GetsartApp()
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("WELCOME OUR App ");
            Console.WriteLine(" ");
           
            Console.Beep();
            Console.WriteLine("1.LogIn");
            Console.WriteLine("2.Sign");
            string choose;

            choose = Console.ReadLine();
            switch (choose)
            {

                case "1":
                    Admin();
                    break;
                case "2":
                    create();

                    break;
            
            }

        }
        static void Admin()
        {


            Console.Clear();
            Console.Beep(); //Beep ku waa Qoraalka iiga dhig socod macnaha mid Asigoo laqoraya ookale  
            Console.Write("Enter Username :");
            string name = Console.ReadLine();
            Console.Beep();
            Console.Write("Enter Your Pssword:");

            string Passwrd = Console.ReadLine();


            if (name == "Ali" && Passwrd == "1234")
            {


                Console.Write("Your're Admin WElcome Mr/Madam'");
                Console.Write("  " + name);
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine(" ");
            }
            else if (name == "Omar" && Passwrd == "5678")
            {
                Console.Beep();
                Console.WriteLine(" ");
                Console.Write("Hello You'r User Welcome Mr/Madam ':" + name);
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine(" ");
            }
            else if
              (name == "Adnan" && Passwrd == "9012")
            {
                Console.WriteLine(" ");
                Console.WriteLine("You're User WElcome Mr/Madam :" + name);
                Console.Beep();

                Console.WriteLine(" ");
                Console.ReadLine();
            }

            else
             
            Console.Clear();
            Console.WriteLine("In Correct ! ");
            Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("1.Forget My Password");
                Console.Beep();
            Console.WriteLine("2.EXIT");

                string Confirm;

            Confirm = Console.ReadLine();
            switch (Confirm)
            {

                case "1":
                   Reset();
                    break;
                case "2":
                    Exit();

                    break;
            
            }
        }
       
        static void Reset(){
            Console.Beep();
            Console.WriteLine("Enter Your Old Username : ");
            string oldUername=Console.ReadLine();
            if(oldUername=="Ali"){
                Console.Beep();
                Console.WriteLine("Your Password Was '1234' ");
              
            }
            else if(oldUername=="Adnan")
            {
                Console.Beep();
                Console.WriteLine("your Password Was '9012");
               
            }
            else if(oldUername=="Omar")
            {
                Console.Beep();
                Console.WriteLine("Your Password Was '5678");
            }
        
            else 
            
              Console.WriteLine("Bye");
                

        
}
        static void Exit()
        {
            Console.Beep();
             Console.WriteLine("");
        
    }
    

          static void create(){
              
            Console.Clear(); //Wxa uunosurtagalinaa inuu pagekale cusub noo furo markaa doorano create nwe account oo number 2 ah 
            Console.Beep();
            Console.Write("Enter NeW Username :");
            string UsernameEnter = Console.ReadLine();

            Console.Write("Enter Again NeW Username :");
            Console.Write(" ");
            string UserameAgain = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Beep();
            Console.Write("Enter NeW Passwrd : ");
            string PasswrdEnter = Console.ReadLine();
            Console.Beep();
            Console.Write("Enter NeW Password Again :");
            Console.Beep();
            string PasswrdAgain = Console.ReadLine();
            Console.Write(" ");
            if (UsernameEnter == UserameAgain && PasswrdEnter == PasswrdAgain)
            {
                Console.WriteLine("");
                Console.Beep();
                Console.Write("***Successefully You Created New Account****  ");
                Console.WriteLine("   ");
                Console.WriteLine("  ");
                Console.Beep();
                Console.WriteLine("Your Username is : " + UsernameEnter);
                Console.Beep();
                Console.WriteLine("Your Pssword is :" + PasswrdEnter);
                Console.Beep();
                Console.WriteLine("");

            }

            else if (UsernameEnter != UserameAgain && PasswrdEnter != PasswrdAgain)
            {
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine("Invalid ! Username and  Password");
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Good Bye");
                Console.Beep();
                Console.WriteLine("");


            }
            else if (UsernameEnter != UserameAgain)
            {
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Invalid ! Your Username ");
                Console.Beep();
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Good Bye");
                Console.WriteLine("");

            }

            else if (PasswrdEnter != PasswrdAgain)
            {
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine("Invalid ! Your Password ");

                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine("Good Bye");
                Console.WriteLine("");
            }

            else
            {
                Console.Beep();
                Console.WriteLine("NULL");
                Console.WriteLine(" ");
            }
        }
        static void ExitApp()
    {
        
        Console.Clear();
        Console.WriteLine("Good Bye");
    }
    }
       
    }


    

