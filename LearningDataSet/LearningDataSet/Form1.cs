using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningDataSet
{
    public partial class Form1 : Form
    {
        const string CONNECTION_STRING = "Server = KARDOS\\SQLEXPRESSKARDY; Database=AdventureWorks;Trusted_Connection=True";
        public Form1()
        {
            InitializeComponent();
            grdDataSet.AutoGenerateColumns = false;
            grdDataSet.DataSource = FillDataset();
            grdDataSet.DataMember = "Person";
        }
        public DataSet FillDataset()
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            string query = @"SELECT [BusinessEntityID]
                            ,[PersonType]
                            ,[NameStyle]
                            ,[Title]
                            ,[FirstName]
                            ,[MiddleName]
                            ,[LastName]
                            ,[Suffix]
                            ,[EmailPromotion]
                            ,[AdditionalContactInfo]
                            ,[Demographics]
                            ,[rowguid]
                            ,[ModifiedDate]
                        FROM [AdventureWorks].[Person].[Person]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Person");

            DataTable dt = ds.Tables["Person"];
            dt.Columns.Add("Name", typeof(string));
            foreach(DataRow dr in dt.Rows)
            {
                dr.SetField("Name", $"{dr["LastName"]} {dr["MiddleName"]} {dr["FirstName"]}");
            }

            return ds;
        }
    }
}
