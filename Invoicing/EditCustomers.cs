using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing
{
    public partial class EditCustomers : Form
    {
        Main main;
        DataGridView dgv;
        string cell1;
        string cell2;
        string cell3;
        string cell4;
        string cell5;
        public EditCustomers(Main main) //add auto-increment in mysql-customers table
        {
            InitializeComponent();
            this.main = main;
            dgv = main.dataGridViewCustomers;
            cell1 = this.dgv.CurrentRow.Cells[0].Value.ToString();
            cell2 = this.dgv.CurrentRow.Cells[1].Value.ToString();
            cell3 = this.dgv.CurrentRow.Cells[2].Value.ToString();
            cell4 = this.dgv.CurrentRow.Cells[3].Value.ToString();
            cell5 = this.dgv.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonEditCustomersSaveData_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            string query = $"UPDATE `mydb`.`customers` SET `CustomerName` = '{this.textBoxEditClientsClient.Text}', `CustomerAddress` = '{this.textBoxEditClientsAddress.Text}', `CustomerMOL` = '{this.textBoxEditClientsMOL.Text}', `CustomerECODE` = '{this.textBoxEditClientsEIK.Text}', `CustomerVATCODE` = '{this.textBoxEditClientsZDDS.Text}' WHERE (`CustomerName` = '{this.main.dataGridViewCustomers.CurrentRow.Cells[0].Value}');";
            MySqlConnection cn = new MySqlConnection(main.connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("customers");
            da.Fill(table);
            this.dgv.CurrentRow.Cells[0].Value = this.textBoxEditClientsClient.Text;
            this.dgv.CurrentRow.Cells[1].Value = this.textBoxEditClientsAddress.Text;
            this.dgv.CurrentRow.Cells[2].Value = this.textBoxEditClientsMOL.Text;
            this.dgv.CurrentRow.Cells[3].Value = this.textBoxEditClientsEIK.Text;
            this.dgv.CurrentRow.Cells[4].Value = this.textBoxEditClientsZDDS.Text;
            
        }

        private void buttonEditCustomersExit_Click(object sender, EventArgs e)
        {
            if (this.textBoxEditClientsClient.Text != cell1 | this.textBoxEditClientsAddress.Text != cell2 | this.textBoxEditClientsMOL.Text != cell3 | this.textBoxEditClientsEIK.Text!=cell4 | this.textBoxEditClientsZDDS.Text != cell5)
            {
                if (MessageBox.Show("Има нови записи в базата. \nВсе още ли искате да излезнете?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
