using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvTop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvTop.Columns)
            {
                //    BindingSource bs = (BindingSource)dgvTop.DataSource;
                //    column.HeaderText = ((DataTable)((BindingSource)dgvTop.DataSource).DataSource).Columns[column.Index].Caption;
                column.HeaderText = dataSet1.DataTable1.Columns[column.Index].Caption;
            }
        }
    }
}
