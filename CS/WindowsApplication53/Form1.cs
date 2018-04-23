using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
        }
        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] {"Aaa", DateTime.Today, 7});
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 4 });
            myTable.Rows.Add(new object[] { "AAA", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "AAA", DateTime.Today.AddDays(1), 14 });
            myTable.Rows.Add(new object[] { "aaa", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "aaa", DateTime.Today.AddDays(1), 10 });


        }
       
    }
}