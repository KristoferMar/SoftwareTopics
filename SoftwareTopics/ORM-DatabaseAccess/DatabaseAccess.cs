using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.ORM_DatabaseAccess
{
    //ORM = Object-relational mapping, used to access object from ex a database.
    public class DatabaseAccess
    {

        //Down below we see some example of how we can use LINQ which is a ORM framework to access data from a database.

        //How to get data using LINQ.
        //public int GetAnInteger(string id)
        //{
        //    using (DatabaseDataContext db = new DatabaseDataContext())
        //    {
        //        var res = db.SomeTable.FirstIrDefault(s => s.Id = id);
        //        if (res == null)
        //            return -1;
        //        return res.SomeTableId;
        //    }
        //}


        //How to set data using LINQ.
        //public void SetSomething(int id, int anotherId)
        //{
        //    using (DatabaseDataContext db = new DatabaseDataContext())
        //    {
        //        SomeTableFromDatabase newTable = new SomeTableFromDatabase
        //        {
        //            id = TableId
        //            anotherId = AnotherTableId;
        //        };
        //    db.SomeTableFromDatabase.InsertOnSubmit(newTable);
        //    db.SubmitChanges();
        //    }
        //}


        //How to delete data using LINQ.
        //public void DeleteSomething(int id)
        //{
        //    using (DatabaseDataContext db = new DatabaseDataContext())
        //    {
        //        Sometable table = db.SomeTable.SingleOrDefault(e => e.tableId == id);
        //        db.SomeTable.DeleteOnSubmit(table);
        //        db.SubmitChanges();
        //    }
        //}


        //How to update data using LINQ
        //public void UpdateSomething(string someString, string someNewString)
        //{
        //    using(DatabaseDataContext db = new DatabaseDataContext())
        //    {
        //        SomeTable table = db.SomeTable.SingleOrDefault(x => x.SomeStringInTable == someString);
        //        table.SomePropertyInTable = someNewString;
        //        db.SubmitChanges();
        //    }
        //}
       
    }
}
