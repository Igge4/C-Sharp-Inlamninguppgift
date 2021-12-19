using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Inlamninguppgift.ListOfCustomers
{
    public class ListOfCustomersGolf
    {

        public static List<Customers> GetListOfCustomersAsGolf()
        {

            List<Customers> customers = new List<Customers>();
            customers.Add(new Customers { Id = 1, FirstName = "Test1", LastName = "C", Email = "mail.com1", WhatOfEvents = Enum.Events.GolfEvent });
            customers.Add(new Customers { Id = 2, FirstName = "Test2", LastName = "C", Email = "mail.com2", WhatOfEvents = Enum.Events.GolfEvent });
            customers.Add(new Customers { Id = 3, FirstName = "Test3", LastName = "C", Email = "mail.com3", WhatOfEvents = Enum.Events.GolfEvent });
            customers.Add(new Customers { Id = 4, FirstName = "Test4", LastName = "C", Email = "mail.com4", WhatOfEvents = Enum.Events.GolfEvent });
            customers.Add(new Customers { Id = 5, FirstName = "Test5", LastName = "C", Email = "mail.com5", WhatOfEvents = Enum.Events.GolfEvent });
            customers.Add(new Customers { Id = 6, FirstName = "Test6", LastName = "C", Email = "mail.com6", WhatOfEvents = Enum.Events.GolfEvent });

            return customers;
        }

        public static void PrintOutGolfCustomers()
        {
            var getCustomer = GetListOfCustomersAsGolf();
            foreach (var item in getCustomer)
            {
                Console.WriteLine("ID: " + item.Id + ".\n"
                                  + " First name: " + item.FirstName + ".\n"
                                  + " Last name: " + item.LastName + ".\n"
                                  + " Email: " + item.Email + ".\n"
                                  + " Evenemanget: " + item.WhatOfEvents + "\n"
                    );
            }
        }
    }
}
