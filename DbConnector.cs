using System.Data;
using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lift
{
    //Database related concepts to be covered here
    internal class DbConnector
    {
        static string dc = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = Elevator_Datab.accdb";//Database connectivty

        static OleDbConnection Connection = new OleDbConnection(dc);//Establishing connection

        static string datacommand = "SELECT * FROM LiftActionLog;";//commanding database

        static OleDbCommand command = new OleDbCommand(datacommand, Connection);


        public void Insertdata(string data)//data insert in databse
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataSet ds = new DataSet();
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(da);
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataRow dr = dt.NewRow();
                //Table Name
                dr["DateAndTime"] = DateTime.Now.ToString();
                dr["Activity"] = data;//Table Name
                //Insertion
                dt.Rows.Add(dr);
                DataSet dsl = ds.GetChanges();
                da.Update(dsl);
                dt.AcceptChanges();
            }
            //Exception Handling
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public DataSet View()
        {
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}

