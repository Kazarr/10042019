using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public InsertInto Insert { get; set; }
        public Form1()
        {
            InitializeComponent();
            SqlConnection ConnectionString = new SqlConnection("Server = KARDOS\\SQLEXPRESSKARDY; Database = AdventureWorks; Trusted_Connection = True");
            Insert = new InsertInto(ConnectionString);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert.ExecuteInsert(txtFirstName.Text, txtLastName.Text);
        }
    }
}
