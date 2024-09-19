using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // For System.Data.SQLite


namespace _100stesNeuesProjektWeilNixGeht
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }

        static void ParseDataTable(DataTable dataTable, RichTextBox output)
        {
            // Iterate through each row in the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Iterate through each column in the DataRow
                foreach (DataColumn column in dataTable.Columns)
                {
                    // Print the column name and the corresponding value in the row
                    output.Text = $"{column.ColumnName}: {row[column]}";
                }
            }
        }

        public void printOut(string output)
        {
            richTextBox1.Text = output;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataClass dataClass = new DataClass(this);
            dataClass.search(textBox1.Text);
        }

    }
}
