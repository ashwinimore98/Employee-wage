using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Adressbook
{
    class AddressProgram


    {
        static void Main()

        {
            ArrayList adress = new
                ArrayList { };
            Boolean menu = true;
            double keychar;
            do
            {
                Console.WriteLine("Welcome to my address program");
                Console.WriteLine("**************");

                Console.WriteLine(" Plese Enter your Firstname");
                string str1 = "Fastname";
                str1 = Console.ReadLine();
                string valueString1 = str1;

                Console.WriteLine(" Plese Enter your Lirstname");
                string str2 = "Lastname";
                str2 = Console.ReadLine();
                string valueString2 = str2;


                Console.WriteLine(" Plese Enter your Address");
                string str3 = "address";
                str3 = Console.ReadLine();
                string valueString3 = str3;

                Console.WriteLine(" Plese Enter your Phonenumber");
                string str4 = "Phonenumber";
                str4 = Console.ReadLine();
                string valueString4 = str4;

                Console.WriteLine(" Plese Enter your State");
                string str5 = "State";
                str5 = Console.ReadLine();
                string valueString5 = str5;

                Console.WriteLine(" Plese Enter your Email");
                string str6 = "Email";
                str6 = Console.ReadLine();
                string valueString6 = str6;

                Console.ReadLine();


                Console.WriteLine("Firstname you entered: " + valueString1);

                Console.WriteLine("Lirstname you entered: " + valueString2);


                Console.WriteLine("Address you entered: " + valueString3);


                Console.WriteLine("Phonenumber you entered: " + valueString4);


                Console.WriteLine("State you entered: " + valueString5);


                Console.WriteLine("Email you entered: " + valueString6);
                Console.ReadLine();




               
            }
            while (menu == true);
        }

        

    }
       
}