using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Data.Repository;
using Assignment2.Data.Models;

namespace Assignment2
{
    class ManageRooms
    {
        IRepository<Rooms> roomsRepository;
        public ManageRooms()
        {
            roomsRepository = new RoomsRepository();
        }
        void PrintAll()
        {
            var collection = roomsRepository.GetAll();
            if(collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.Id+"\t"+item.RtCode+"\t"+item.Status);
                }
            }
        }
        public void Run()
        {
            PrintAll();
        }
    }
}
