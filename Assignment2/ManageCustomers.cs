using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Data.Repository;
using Assignment2.Data.Models;

namespace Assignment2
{
    class ManageCustomers
    {
        IRepository<Customers> customersRepository;
        public ManageCustomers()
        {
            customersRepository = new CustomersRepository();    //????
        }
        void PrintAll()
        {
            var collection = customersRepository.GetAll();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine($"{item.Id} \t {item.RoomNo} \t {item.CName} \t {item.Address} \t {item.Phone} \t {item.Email} \t {item.CheckIn} \t {item.TotalPersons} \t {item.BookingDays} \t {item.Advance}");
                }
            }
        }
        public void Run()
        {
            PrintAll();
        }
    }
}
