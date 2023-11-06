using QuanLyQuanAn.DAO;
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

namespace QuanLyQuanAn
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {

            string query = "EXEC USP_GetAccountByUserName @userName = N'K9'";
            DataProvider provider = new DataProvider();
            dtgvAccount.DataSource = provider.ExecuteQuery(query);

        }
    }
}
