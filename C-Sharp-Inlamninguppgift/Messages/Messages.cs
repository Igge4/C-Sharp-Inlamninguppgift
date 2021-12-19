using C_Sharp_Inlamninguppgift.ListOfCustomers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Inlamninguppgift
{
    public class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Välkommen till Mitt system");
            Thread.Sleep(2000);
        }

        public static void WhatDoYouWantToCheck()
        {
            Console.WriteLine("I vårt system finns följande");
            Console.WriteLine(" 1. Fotboll-evenemang " + "\n" + " 2. basket-evenemang " + "\n" + " 3. golf-evenemang " + "\n" + " 4. boxning-evenemang " + "\n");
            Console.WriteLine("Vad vill du kolla? Välj 1, 2, 3 eller 4. Tack! ");
        }
        public static void UserEntersValue()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    Console.WriteLine("Du valde fotboll-evenemang" + "\n");
                    Console.WriteLine("Vänta lite...");
                    Thread.Sleep(5000);
                    break;
                case 2:
                    Console.WriteLine("Du valde basket-evenemang");
                    Console.WriteLine("Vänta lite...");
                    Thread.Sleep(5000);
                    break;
                case 3:
                    Console.WriteLine("Du valde golf-evenemang");
                    Console.WriteLine("Vänta lite...");
                    Thread.Sleep(5000);
                    break;
                case 4:
                    Console.WriteLine("Du valde boxning-evenemang");
                    Console.WriteLine("Vänta lite...");
                    Thread.Sleep(5000);
                    break;
                default:
                    Console.WriteLine("Don't be idiot");
                    break;
            }
            if(input == 1)
            {
                ListOfCustomersFootball.PrintOutFootballCustomers();
            }
            if(input == 2)
            {
                ListOfCustomersBasket.PrintOutBasketCustomers();
            }
            if(input == 3)
            {
                ListOfCustomersGolf.PrintOutGolfCustomers();
            }
            if(input == 4)
            {
                ListOfCustomersBoxning.PrintOutBoxningCustomers();
            }           
        }
        public static void Message()
        {
            Console.WriteLine("Här får du resulatet som du sökte på...");
            Thread.Sleep(5000);
        }
        public static void WhatDoYouWantToDo() 
        {
            Console.WriteLine("Det finns olika alternativ du kan göra med deltagarna");
            Thread.Sleep(3000);
            Console.WriteLine("Välj 1 om du vill avboka en deltagare från evenemanget");

            Console.WriteLine("Välj 2 om du vill ge rabatt-kod till en deltagare från evenemanget");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input == 1)
            {
                RemoveOneUserFromTheEvent();
            }
            if(input== 2)
            {
                GiveDiscount();
            }
        }
        public static void RemoveOneUserFromTheEvent()
        {
            Console.WriteLine("Vill du ta bort en deltagare från evenemanget? ja/nej?");
            var input = Console.ReadLine();
            if(input == "ja" || input == "Ja" || input == "JA")
            {
                Console.WriteLine("Välj vilket id på deltagare du vill avboka");
                int inputId = Convert.ToInt32(Console.ReadLine());

                switch (inputId)
                {
                    case 1:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren avbokad från evenemanget");
                        Thread.Sleep(3000);
                        break;
                    case 2:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren avbokad från evenemanget");
                        Thread.Sleep(3000);
                        break;
                    case 3:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren avbokad från evenemanget");
                        Thread.Sleep(3000);
                        break;
                    case 4:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren avbokad från evenemanget");
                        Thread.Sleep(3000);
                        break;
                    case 5:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren avbokad från evenemanget");
                        Thread.Sleep(3000);
                        break;
                    case 6:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren borta från evenemanget");
                        Thread.Sleep(3000);
                        break;
                    default:
                        Console.WriteLine("Don't be idiot");
                        break;
                }              
            }
        }
        public static void GiveDiscount()
        {

            Console.WriteLine("Vill du ge rabatt till en deltagare från evenemanget? ja/nej?");
            var input = Console.ReadLine();
            if (input == "ja" || input == "Ja" || input == "JA")
            {
                Console.WriteLine("Välj vilket id på deltagare du vill ge rabatt till");
                int inputId = Convert.ToInt32(Console.ReadLine());

                Random discount = new Random();
                int discountNumbers = discount.Next(10000, 99999);

                switch (inputId)
                {
                    case 1:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren fått rabatt med koden: " + discountNumbers);
                        Thread.Sleep(3000);
                        break;
                    case 2:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren fått rabatt med koden: " + discountNumbers);
                        Thread.Sleep(3000);
                        break;
                    case 3:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren fått rabatt med koden: " + discountNumbers);
                        Thread.Sleep(3000);
                        break;
                    case 4:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren fått rabatt med koden: " + discountNumbers);
                        Thread.Sleep(3000);
                        break;
                    case 5:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren fått rabatt med koden: " + discountNumbers);
                        Thread.Sleep(3000);
                        break;
                    case 6:
                        Console.WriteLine("Du valde deltagare med ID " + inputId + "\n");
                        Console.WriteLine("Vänta lite...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Nu är deltagaren fått rabatt med koden: " + discountNumbers);
                        Thread.Sleep(3000);
                        break;
                    default:
                        Console.WriteLine("Don't be idiot");
                        break;
                }
            }
        }
        public static void WhatDoYouWantToDoNow()
        {
            Console.WriteLine("Vad vill du göra nu?");
            Thread.Sleep(3000);
            Console.WriteLine("Tryck 1 - Om du vill tillbaka till main" + "\n");
            Console.WriteLine("Tryck 2 - Om du vill avsluta systemet" + "\n");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
            }
            if (input == 2)
            {
                Console.WriteLine("Välkommen åter!");
                Thread.Sleep(5000);
            }

        }
    }
}
