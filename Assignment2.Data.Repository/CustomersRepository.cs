using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Data.Models;
using Dapper;
using System.Data;

namespace Assignment2.Data.Repository
{
    public class CustomersRepository:IRepository<Customers>
    {
        HotelDbContext db;
        public CustomersRepository()
        {
            db = new HotelDbContext();
        }

        public int Delete(int id)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Execute("Delete * from Customers where Id=@CustId", new { CustId = id }); //Cannot directly use Id here
            } 
        }

        public IEnumerable<Customers> GetAll()
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Query<Customers>("Select Id, RoomNo, CName, Address, Phone, Email, CheckIn, TotalPersons, BookingDays, Advance from Customers");
                /* If want to use Stored Procedure
                 * return conn.Query<Customers>("NameOfStoredProcedure", commandType:CommandType.StoredProcedure);
                 */
            }
        }

        public Customers GetById(int id)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.QueryFirstOrDefault<Customers>("Select Id, RoomNo, CName, Address, Phone, Email, CheckIn, TotalPersons, BookingDays, Advance from Customers where id=CustId", new{ CustId = id });
            }        }

        public int Insert(Customers item)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Execute("Insert into Customers values(@RoomNo, @CName, @Address, @Phone, @Email, @CheckIn, @TotalPersons, @BookingDays, @Advance)", item);
            }
        }

        public int Update(Customers item)
        {
            using (IDbConnection conn = db.GetConnection())
            {
                return conn.Execute("Update Customers set RoomNo=@RoomNo, CName=@CName, Address=@Address, Phone=@Phone, Email=@Email, CheckIn=@CheckIn, TotalPersons=@TotalPersons, BookingDays=@BookingDays, Advance=@Advance where Id=@Id", item);
            }        }
    }
}
