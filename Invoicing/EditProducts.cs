using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;

namespace Invoicing
{
    public partial class EditProducts : Form
    {
        Main form1;
        DataGridView dgv;
        string cell1;
        string cell2;
        string cell3;
        string cell4;
        string cell5;
        public EditProducts(Main form1)
        {
            InitializeComponent();
            this.form1 = form1;
            dgv = form1.dataGridViewProducts;
            cell1 = this.dgv.CurrentRow.Cells[0].Value.ToString();
            cell2 = this.dgv.CurrentRow.Cells[1].Value.ToString();
            cell3 = this.dgv.CurrentRow.Cells[2].Value.ToString();
            cell4 = this.dgv.CurrentRow.Cells[3].Value.ToString();
            cell5 = this.dgv.CurrentRow.Cells[4].Value.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.textBoxForm2KodNaProdukta.Enabled = false;
        }


        private void buttonForm2SaveData_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            string query = $"UPDATE `mydb`.`products` SET `PRODUCTNAME` = '{this.textBoxForm2Naimenovanie.Text}', `PRODUCTMEASURE` = '{this.textBoxForm2Mqrka.Text}', `PRODUCT_DOST_CENA` = '{this.textBoxForm2DostavnaCena.Text}', `PRODUCT_PROD_CENA` = '{this.textBoxForm2ProdajnaCena.Text}' WHERE (`PRODUCTID` = '{this.dgv.CurrentRow.Cells[0].Value}');";
            MySqlConnection cn = new MySqlConnection(form1.connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("products");
            da.Fill(table);
            this.dgv.CurrentRow.Cells[1].Value = this.textBoxForm2Naimenovanie.Text;
            this.dgv.CurrentRow.Cells[2].Value = this.textBoxForm2Mqrka.Text;
            this.dgv.CurrentRow.Cells[3].Value = this.textBoxForm2DostavnaCena.Text;
            this.dgv.CurrentRow.Cells[4].Value = this.textBoxForm2ProdajnaCena.Text;
            form1.ProductsComboBoxOnLoad();
        }

        private void buttonForm2Exit_Click(object sender, EventArgs e)
        {
            if (this.textBoxForm2Naimenovanie.Text!=cell2 | this.textBoxForm2Mqrka.Text!=cell3 | this.textBoxForm2DostavnaCena.Text != cell4 | this.textBoxForm2ProdajnaCena.Text != cell5)
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
