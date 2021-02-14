using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Book.Data
{
    public class BookServices
    {
        string Connect = "Data Source=localhost;Initial Catalog=Book;Integrated Security=True";
        public IEnumerable<Book> GetAllStudent()
        {
            List<Book> listBook = new List<Book>();
            using (SqlConnection con = new SqlConnection(Connect))
            {
                SqlCommand cmd = new SqlCommand("GetAllBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Book book = new Book();
                    book.ID = Convert.ToInt32(rdr["ID"]);
                    book.bookName = rdr["bookName"].ToString();
                    book.Author = rdr["Author"].ToString();
                    book.Price = Convert.ToInt32(rdr["Price"]);


                    listBook.Add(book);
                }
                con.Close();
            }
            return listBook;
        }
    }
}
