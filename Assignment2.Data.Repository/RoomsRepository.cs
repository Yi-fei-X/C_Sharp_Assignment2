using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Data.Models;
using Dapper;
using System.Data;

namespace Assignment2.Data.Repository
{
    public class RoomsRepository : IRepository<Rooms>
    {
        HotelDbContext db;
        public RoomsRepository()
        {
            db = new HotelDbContext();
        }
        public int Delete(int id)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Execute("Delete * from Rooms where id=@RoomId", new { RoomId = id });
            }
        }

        public IEnumerable<Rooms> GetAll()
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Query<Rooms>("Select Id, RTCode, Status from Rooms");
            }
        }

        public Rooms GetById(int id)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.QueryFirstOrDefault<Rooms>("Select Id, RTCode, Status from Rooms where id=@RoomId", new { RoomId = id });
            }
        }

        public int Insert(Rooms item)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Execute("Insert into Rooms values(@id, @RTCode, @Status)", item);
            }
        }

        public int Update(Rooms item)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Execute("Update Rooms set RTCode=@RTCode, Status=@Status where id=@id", item);
            }
        }
    }
}
