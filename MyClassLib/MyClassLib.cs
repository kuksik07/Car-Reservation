using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public interface IReservation
    {
        void SetDates(DateTime dateStart, DateTime dateEnd);
        DateTime GetDateStart();
        DateTime GetDateEnd();
        int GetLenReservation();
        int GetLenReservation(DateTime dateEnd, DateTime dateStart);
    }

    public class Reservation : IReservation
    {
        private DateTime dateStart = new DateTime();
        private DateTime dateEnd = new DateTime();

        public void SetDates(DateTime dateStart, DateTime dateEnd)
        {
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }

        public DateTime GetDateStart()
        {
            return dateStart;
        }

        public DateTime GetDateEnd()
        {
            return dateEnd;
        }

        public int GetLenReservation()
        {
            return Convert.ToInt32(dateEnd.Subtract(dateStart).TotalDays);
        }

        public int GetLenReservation(DateTime dateEnd, DateTime dateStart)
        {
            return Convert.ToInt32(dateEnd.Subtract(dateStart).TotalDays);
        }

        static public string FormattedData(DateTime date)
        {
            DateTime newData = Convert.ToDateTime(date);
            return newData.ToString("dd.MM.yyyy");
        }

        static public string FormattedData(string date)
        {
            DateTime newData = Convert.ToDateTime(Convert.ToDateTime(date));
            return newData.ToString("dd.MM.yyyy");
        }
    }

    public class Db
    {
        static public void sqlNonQuery(string query)
        {
            string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../../../lab3_main/CarReservation.mdb;";

            using (OleDbConnection connection = new OleDbConnection(connectString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
            } 
        }

        static public DataTable GetTableFromDb(string query)
        {
            string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../../../lab3_main/CarReservation.mdb;";
            DataTable result = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connectString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader Reader = command.ExecuteReader();
                result.Load(Reader);
                Reader.Close();
            }
            return result;
        }
    }
}
