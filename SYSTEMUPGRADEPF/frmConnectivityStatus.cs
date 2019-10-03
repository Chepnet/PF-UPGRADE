using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Common;

namespace SYSTEMUPGRADEPF
{
    public partial class frmConnectivityStatus : Form
    {
        public frmConnectivityStatus()
        {
            InitializeComponent();
        }
        public static string DatabaseName { get; }

       


        private void frmConnectivityStatus_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Environment.MachineName;
            txtDatabaseName.Text = GlobalVariable.connectionstring.ToString();
            txtDatabaseName.Text = GlobalVariable.dbname.ToString();
        

        }
    }
}

