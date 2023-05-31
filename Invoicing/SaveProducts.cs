using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Invoicing
{
    public partial class SaveProducts : Form
    {
        Main form1;
        public SaveProducts(Main form1)
        {
            this.form1 = form1;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            this.form1.dataGridViewProducts.SelectAll();
            for (int i = 0; i < this.form1.dataGridViewProducts.Rows.Count; i++) //add to db
            {
                string query = $"INSERT INTO products (productid, productcode, productname, productmeasure, product_dost_cena, product_prod_cena) VALUES ('{this.form1.dataGridViewProducts.Rows[i].Cells[0].Value.ToString()}','{this.form1.dataGridViewProducts.Rows[i].Cells[0].Value.ToString()}', '{this.form1.dataGridViewProducts.Rows[i].Cells[1].Value.ToString()}', '{this.form1.dataGridViewProducts.Rows[i].Cells[2].Value.ToString()}', '{this.form1.dataGridViewProducts.Rows[i].Cells[3].Value.ToString()}', '{this.form1.dataGridViewProducts.Rows[i].Cells[4].Value.ToString()}' ) ON DUPLICATE KEY UPDATE productid = productid";
                MySqlConnection cn = new MySqlConnection(form1.connection);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("products");
                da.Fill(table);

            }
            for (int i = 0; i < this.form1.dataGridViewProducts.Rows.Count; i++) //add to combobox
            {
                string query2 = $"SELECT PRODUCTNAME FROM PRODUCTS where productname = {this.form1.dataGridViewProducts.Rows[i].Cells[0].Value}";
                MySqlConnection cn2 = new MySqlConnection(form1.connection);
                cn2.Open();
                MySqlCommand cmd2 = new MySqlCommand(query2, cn2);
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                DataTable table2 = (DataTable)this.form1.comboBoxProducts.DataSource;
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    MessageBox.Show("Ima takuv produkt");
                    return;
                }
                else
                {
                    cn2.Close();
                    cn2.Open();
                    da2.Fill(table2);
                    this.form1.comboBoxProducts.DataSource = table2;
                    this.Close();
                }
                this.form1.ProductsComboBoxOnLoad();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveSelectedRow_Click(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable)this.form1.comboBoxProducts.DataSource;
            if(this.form1.dataGridViewProducts.SelectedCells.Count == 0)
            {
                this.Close();
                MessageBox.Show("Моля изберете колона, която искате да добавите");
                this.form1.WindowState = FormWindowState.Normal;
            }
            else
            {
                //this.form1.comboBoxProducts.Items.Add(this.form1.dataGridViewProducts.CurrentRow.Cells[1].Value.ToString());
                string query = $"select productid from products where productid = {this.form1.dataGridViewProducts.CurrentRow.Cells[0].Value}";
                MySqlConnection cn = new MySqlConnection(form1.connection);
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cn);
                DataTable dt = (DataTable)this.form1.comboBoxProducts.DataSource;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Вече има продукт с тавъв код", "Attention");
                    return;
                }
                else
                {
                    cn.Close();
                    cn.Open();
                    string insertQuery = $"INSERT INTO products (productid, productcode, productname, productmeasure, product_dost_cena, product_prod_cena) VALUES ('{this.form1.dataGridViewProducts.CurrentRow.Cells[0].Value.ToString()}','{this.form1.dataGridViewProducts.CurrentRow.Cells[0].Value.ToString()}', '{this.form1.dataGridViewProducts.CurrentRow.Cells[1].Value.ToString()}', '{this.form1.dataGridViewProducts.CurrentRow.Cells[2].Value.ToString()}', '{this.form1.dataGridViewProducts.CurrentRow.Cells[3].Value.ToString()}', '{this.form1.dataGridViewProducts.CurrentRow.Cells[4].Value.ToString()}' )";
                    cmd = new MySqlCommand(insertQuery, cn);
                    DataTable table = new DataTable("products");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(table);
                    this.form1.comboBoxProducts.DataSource = dt;
                    this.Close();
                }
                //dt.Rows.Add(this.form1.dataGridViewProducts.CurrentRow.Cells[1].Value.ToString());
                //this.form1.comboBoxProducts.DataSource = dt;
                //this.Close();
            }
            this.form1.ProductsComboBoxOnLoad();
            //this.form1.comboBoxProducts.Items.Add(this.form1.dataGridViewProducts.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
