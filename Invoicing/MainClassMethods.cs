using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing
{
    public partial class Main : Form
    {
        private void InitNewInvoice(bool b)
        {
            this.textBoxDanuchnaOsnova.Enabled = b;
            this.textBoxDDS.Enabled = b;
            this.textBoxSumaZaPlashtane.Enabled = b;
            this.buttonRefresh.Enabled = b;
            this.buttonDeleteRow.Enabled = b;
            this.buttonSave.Enabled = b;
            this.buttonCancel.Enabled = b;
            this.dataGridViewAddedProduct.Enabled = b;
            this.groupBoxInvoice.Enabled = b;
            this.groupBoxTotal.Enabled = b;
            this.groupBoxClients.Enabled = b;
            this.groupBoxNachinNaPlashtane.Enabled = b;
            this.groupBoxPoluchatel.Enabled = b;
            this.groupBoxProducts.Enabled = b;
            this.checkBoxOriginal.Enabled = b;
            this.dataGridViewAddedProduct.ReadOnly = true;
            this.textBoxNumberInvoice.Enabled = b;
        }
        private void InitProductsTab(bool b)
        {
            this.textBoxProductsKodNaProdukta.Enabled = b;
            this.textBoxProductsNaimenovanie.Enabled = b;
            this.textBoxProductsMqrka.Enabled = b;
            this.textBoxProductsDostavnaCena.Enabled = b;
            this.textBoxProductsProdajnaCena.Enabled = b;
            this.buttonProductsEdit.Enabled = b;
            this.buttonProductsCancel.Enabled = b;
            this.buttonCancel.Enabled = b;
            this.buttonProductsSave.Enabled = b;
            this.buttonProductsDelete.Enabled = b;
            this.dataGridViewProducts.ReadOnly = true;
        }

        private void InitCustomersTab(bool b)
        {
            this.textBoxCustomersAddress.Enabled = b;
            this.textBoxCustomersClient.Enabled = b;
            this.textBoxCustomersEIK.Enabled = b;
            this.textBoxCustomersMOL.Enabled = b;
            this.textBoxCustomersZDDS.Enabled = b;
            this.buttonCustomersCancel.Enabled = b;
            this.buttonCustomersDelete.Enabled = b;
            this.buttonCustomersEdit.Enabled = b;
            this.buttonCustomersSave.Enabled = b;
            this.dataGridViewCustomers.ReadOnly = true;
        }
        private void ProductsAddToDataGrid() // https://stackoverflow.com/questions/28351471/error-rows-cannot-be-programatically-added-to-datagridviews-row-collection-whe
        {
            //this.dataGridViewProducts.Rows.Add(this.textBoxProductsKodNaProdukta.Text, this.textBoxProductsNaimenovanie.Text, this.textBoxProductsMqrka.Text, this.textBoxProductsDostavnaCena.Text, this.textBoxProductsProdajnaCena.Text);
            if (int.TryParse(this.textBoxProductsKodNaProdukta.Text, out _))
            {
                string query = $"select productid from products where productid = {this.textBoxProductsKodNaProdukta.Text}";
                MySqlConnection cn = new MySqlConnection(connection);
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cn);
                DataTable dt = (DataTable)this.dataGridViewProducts.DataSource;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Вече има продукт с тавъв код", "Attention");
                    return;
                }
                else
                {
                    dt.Rows.Add(this.textBoxProductsKodNaProdukta.Text, this.textBoxProductsNaimenovanie.Text, this.textBoxProductsMqrka.Text, this.textBoxProductsDostavnaCena.Text, this.textBoxProductsProdajnaCena.Text);
                    this.dataGridViewProducts.DataSource = dt;
                }
            }
            else
            {
                return;
            }

        }

        private void CustomersAddToDataGrid()
        {
            DataTable table = (DataTable)this.dataGridViewCustomers.DataSource;
            table.Rows.Add(this.textBoxCustomersClient.Text, this.textBoxCustomersAddress.Text, this.textBoxCustomersMOL.Text, this.textBoxCustomersEIK.Text, this.textBoxCustomersZDDS.Text);
        }
        private void CustomersSaveAll()
        {
            this.dataGridViewCustomers.SelectAll();
            for (int i = 0; i < this.dataGridViewCustomers.Rows.Count; i++)
            {
                string query = $"INSERT INTO `mydb`.`customers` (`CustomersID`,`CustomerName`, `CustomerAddress`, `CustomerMOL`, `CustomerECODE`, `CustomerVATCODE`) VALUES ('{this.dataGridViewCustomers.Rows[i].Index + 1}','{this.dataGridViewCustomers.Rows[i].Cells[0].Value}', '{this.dataGridViewCustomers.Rows[i].Cells[1].Value}', '{this.dataGridViewCustomers.Rows[i].Cells[2].Value}', '{this.dataGridViewCustomers.Rows[i].Cells[3].Value}', '{this.dataGridViewCustomers.Rows[i].Cells[4].Value}') ON DUPLICATE KEY UPDATE customersid = customersid";
                MySqlConnection cn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("customers");
                da.Fill(table);
                NextCustomerID();
            }
        }

        private void DeleteCustomerFromRow()
        {
            string query = $"DELETE FROM `mydb`.`customers` WHERE (`CustomersID` = '{this.dataGridViewCustomers.CurrentCell.RowIndex + 1}')";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("customers");
            da.Fill(table);
            foreach (DataGridViewCell cell in this.dataGridViewCustomers.SelectedCells)
            {
                try
                {
                    if (cell.Selected)
                    {
                        this.dataGridViewCustomers.Rows.RemoveAt(cell.RowIndex);
                    }
                }
                catch (InvalidOperationException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ProductsSaveToComboBox()
        {
            SaveProducts form3 = new SaveProducts(this);
            form3.Show();
        }

        private void DeleteProductFromRow()
        {
            //this.dataGridViewProducts.Select();
            string query = $"DELETE FROM `mydb`.`products` WHERE (`PRODUCTID` = '{this.dataGridViewProducts.CurrentRow.Cells[0].Value}');";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("products");
            da.Fill(table);
            foreach (DataGridViewCell cell in this.dataGridViewProducts.SelectedCells)
            {
                try
                {
                    if (cell.Selected)
                    {
                        this.dataGridViewProducts.Rows.RemoveAt(cell.RowIndex);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void AddClients()
        {
            comboBoxClients.Items.Clear();
            string query = "SELECT CUSTOMERNAME FROM CUSTOMERS";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("customers");
            da.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                this.comboBoxClients.Items.Add(row["CUSTOMERNAME"].ToString());
            }

        }

        private void ProductsDataGridViewOnLoad()
        {
            this.dataGridViewProducts.Columns.Clear();
            string query = $"SELECT PRODUCTCODE as \"Код\",PRODUCTNAME as \"Наименование на продукта\",PRODUCTMEASURE as \"Мярка\",PRODUCT_DOST_CENA AS \"Дост. цена\",PRODUCT_PROD_CENA as \"Прод. цена\"from products";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("products");
            da.Fill(table);
            this.dataGridViewProducts.DataSource = table;
            this.dataGridViewProducts.Columns[0].Width = 175;
            this.dataGridViewProducts.Columns[1].Width = 300;
            this.dataGridViewProducts.Columns[2].Width = 125;
            this.dataGridViewProducts.Columns[3].Width = 125;
            this.dataGridViewProducts.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void CustomersDataGridViewOnLoad()
        {
            this.dataGridViewCustomers.Columns.Clear();
            string query = $"select CustomerName as \"Име\", CustomerAddress as \"Адрес\", CustomerMOL as \"МОЛ\", CustomerECODE as \"ЕИК\", CustomerVATCODE as \"ИН по ЗДДС\" from customers;";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("customers");
            da.Fill(table);
            this.dataGridViewCustomers.DataSource = table;
            this.dataGridViewCustomers.Columns[0].Width = 175;
            this.dataGridViewCustomers.Columns[1].Width = 300;
            this.dataGridViewCustomers.Columns[2].Width = 125;
            this.dataGridViewCustomers.Columns[3].Width = 125;
            this.dataGridViewCustomers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        internal void ProductsComboBoxOnLoad()
        {
            string query = "SELECT productname FROM products;";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("products");
            da.Fill(table);
            this.comboBoxProducts.DataSource = table;
            this.comboBoxProducts.ValueMember = "productname";
            this.comboBoxProducts.SelectedIndex = -1;
        }

        private void NextInvoiceNumber()
        {
            string query = "SELECT INVOICENUMBER FROM mydb.invoices order by INVOICENUMBER desc limit 1;";
            fakNo = "";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("invoices");
            da.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                fakNo = row["invoicenumber"].ToString();
            }
            if (fakNo == String.Empty)
            {
                fakNo = "1";
                this.textBoxNumberInvoice.Text = (int.Parse(fakNo)).ToString();
            }
            else
            {
                this.textBoxNumberInvoice.Text = (int.Parse(fakNo) + 1).ToString();
            }
        }

        private void NextCustomerID()
        {
            string query = $"select customersID from customers order by CustomersID desc limit 1";
            cusNo = "";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("customers");
            da.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                cusNo = row["customersID"].ToString();
            }
            if (cusNo == String.Empty)
            {
                cusNo = "1";
            }
            else
            {
                cusNo = (int.Parse(cusNo) + 1).ToString();
            }
        }

        public string InvoiceNumberToString(string fakNo)
        {
            string s = "";
            int nf = int.Parse(fakNo);
            int digits = 0;
            while (nf != 0)
            {
                nf /= 10;
                digits++;
            }
            int nuls = 10 - digits;
            for (int i = 0; i < nuls; i++)
            {
                s += "0";
            }
            s += fakNo;
            return s;
        }

        private void DataGridViewAllInvoicesOnLoad()
        {
            string query = $"SELECT DISTINCT INVOICENUMBER as \"Фактура\", MyFirmName as \"Фирма\", INVOICEVATDATE as \"Дата\", INVOICESUM as \"Дан. основа\", INVOICEVAT as \"ДДС\", INVOICETOTAL as \"Общо\" from invoices join myfirms on (myfirms.myfirmid = invoices.myfirmid) order by INVOICENUMBER asc";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("invoices, myfirms");
            da.Fill(table);
            this.dataGridViewAllInvoices.DataSource = table;
            this.dataGridViewAllInvoices.Columns[0].Width = 175;
            this.dataGridViewAllInvoices.Columns[1].Width = 300;
            this.dataGridViewAllInvoices.Columns[2].Width = 125;
            this.dataGridViewAllInvoices.Columns[3].Width = 125;
            this.dataGridViewAllInvoices.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Invoice_ProductData()
        {
            if (this.dataGridViewAddedProduct.Rows.Count >= 2)
            {
                for (int i = 0; i < this.dataGridViewAddedProduct.Rows.Count - 1; i++)
                {
                    string query = $"INSERT INTO invoice_product(INVPRODID, PRODUCTMEASURE, PRODUCTUNITPRICE, INVOICEQUANTITY, INVOICEID, PRODUCTID) VALUES ('{double.Parse(this.textBoxNumberInvoice.Text) + i}', '{this.dataGridViewAddedProduct.Rows[i].Cells[2].Value}', '{this.textBoxSumaZaPlashtane.Text}','1', '{this.textBoxNumberInvoice.Text}', '{this.dataGridViewAddedProduct.Rows[i].Cells[0].Value}')";
                    MySqlConnection cn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable("invoice_product");
                    da.Fill(table);
                }
            }
            else
            {
                string query = $"INSERT INTO invoice_product(INVPRODID, PRODUCTMEASURE, PRODUCTUNITPRICE, INVOICEQUANTITY, INVOICEID, PRODUCTID) VALUES ('{this.textBoxNumberInvoice.Text}', '{this.dataGridViewAddedProduct.Rows[0].Cells[2].Value}', '{this.textBoxSumaZaPlashtane.Text}','1', '{this.textBoxNumberInvoice.Text}', '{this.comboBoxProducts.SelectedIndex + 1}')";
                MySqlConnection cn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("invoice_product");
                da.Fill(table);
            }
        }

        private void RefreshPage()
        {
            Main main = new Main();
            main.Show();
            this.Dispose(false); //either that or - this.Hide();

        }

        private void DataGridViewSelectedInvoiceProductInfo()
        {
            string query = $"select p.PRODUCTCODE as \"Код\", p.productname as \"Наименование на продукт\", p.PRODUCTMEASURE as \"Мярка\", ip.INVOICEQUANTITY as \"Количество\", p.PRODUCT_PROD_CENA as \"Сума\" from invoice_product ip join products p on(ip.PRODUCTID = p.PRODUCTID) join invoices i on(ip.INVOICEID = i.INVOICEID) where i.INVOICENUMBER = {this.dataGridViewAllInvoices.CurrentRow.Cells[0].Value}";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("invoice_product, invoices, products");
            da.Fill(table);
            this.dataGridViewSelectedProduct.DataSource = table;
            this.dataGridViewSelectedProduct.Columns[0].Width = 175;
            this.dataGridViewSelectedProduct.Columns[1].Width = 300;
            this.dataGridViewSelectedProduct.Columns[2].Width = 125;
            this.dataGridViewSelectedProduct.Columns[3].Width = 125;
            this.dataGridViewSelectedProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SaveToInvoice()
        {
            string query;
            string invoice = this.textBoxNumberInvoice.Text;
            if (this.dataGridViewAddedProduct.Rows.Count >= 2)
            {
                if (this.radioButton20Percent.Checked)
                {
                    var date = DateTime.ParseExact(this.dateTimePicker1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).AddDays(-2);
                    string dateFormatted = date.ToString("dd.MM.yyyy");
                    for (int i = 0; i < this.dataGridViewAddedProduct.Rows.Count - 1; i++)
                    {
                        query = $"INSERT INTO invoices(INVOICEID, INVOICENUMBER, INVOICEVATDATE,INVOICEDEALDATE, INVOICESUM, INVOICEVAT, INVOICETOTAL, INVOICEVATPERCENT, CUSTOMERID, MYFIRMID) VALUES ('{double.Parse(this.textBoxNumberInvoice.Text) + i}', '{invoice}', '{this.dateTimePicker1.Text}','{dateFormatted}', '{this.textBoxDanuchnaOsnova.Text}', '{this.textBoxDDS.Text}', '{this.textBoxSumaZaPlashtane.Text}', '{this.radioButton20Percent.Text}', '{this.comboBoxClients.SelectedIndex + 1}', '{this.comboBoxClients.SelectedIndex + 1}')";
                        MySqlConnection cn = new MySqlConnection(connection);
                        MySqlCommand cmd = new MySqlCommand(query, cn);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable("invoices");
                        da.Fill(table);
                    }
                    Invoice_ProductData();
                    MessageBox.Show("Invoice has been successfully saved to the database!");
                    RefreshPage();

                }
                else
                {
                    var date = DateTime.ParseExact(this.dateTimePicker1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).AddDays(-2);
                    string dateFormatted = date.ToString("dd.MM.yyyy");
                    for (int i = 0; i < this.dataGridViewAddedProduct.Rows.Count - 1; i++)
                    {
                        query = $"INSERT INTO invoices(INVOICEID, INVOICENUMBER, INVOICEVATDATE,INVOICEDEALDATE, INVOICESUM, INVOICEVAT, INVOICETOTAL, INVOICEVATPERCENT, CUSTOMERID, MYFIRMID) VALUES ('{double.Parse(this.textBoxNumberInvoice.Text) + i}', '{invoice}','{this.dateTimePicker1.Text}','{dateFormatted}', '{this.textBoxDanuchnaOsnova.Text}', '{this.textBoxDDS.Text}', '{this.textBoxSumaZaPlashtane.Text}', '{this.radioButton9Percent.Text}', '{this.comboBoxClients.SelectedIndex + 1}', '{this.comboBoxClients.SelectedIndex + 1}')";
                        MySqlConnection cn = new MySqlConnection(connection);
                        MySqlCommand cmd = new MySqlCommand(query, cn);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable("invoices");
                        da.Fill(table);
                    }
                    Invoice_ProductData();
                    MessageBox.Show("Invoice has been successfully saved to the database!");
                    RefreshPage();
                }
            }
            else
            {
                if (this.radioButton20Percent.Checked)
                {
                    var date = DateTime.ParseExact(this.dateTimePicker1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).AddDays(-2);
                    string dateFormatted = date.ToString("dd.MM.yyyy");
                    query = $"INSERT INTO invoices(INVOICEID, INVOICENUMBER, INVOICEVATDATE,INVOICEDEALDATE, INVOICESUM, INVOICEVAT, INVOICETOTAL, INVOICEVATPERCENT, CUSTOMERID, MYFIRMID) VALUES ('{this.textBoxNumberInvoice.Text}', '{this.textBoxNumberInvoice.Text}', '{this.dateTimePicker1.Text}','{dateFormatted}', '{this.textBoxDanuchnaOsnova.Text}', '{this.textBoxDDS.Text}', '{this.textBoxSumaZaPlashtane.Text}', '{this.radioButton20Percent.Text}', '{this.comboBoxClients.SelectedIndex + 1}', '{this.comboBoxClients.SelectedIndex + 1}')";
                }
                else
                {
                    var date = DateTime.ParseExact(this.dateTimePicker1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).AddDays(-2);
                    string dateFormatted = date.ToString("dd.MM.yyyy");
                    query = $"INSERT INTO invoices(INVOICEID, INVOICENUMBER, INVOICEVATDATE,INVOICEDEALDATE, INVOICESUM, INVOICEVAT, INVOICETOTAL, INVOICEVATPERCENT, CUSTOMERID, MYFIRMID) VALUES ('{this.textBoxNumberInvoice.Text}', '{this.textBoxNumberInvoice.Text}','{this.dateTimePicker1.Text}','{dateFormatted}', '{this.textBoxDanuchnaOsnova.Text}', '{this.textBoxDDS.Text}', '{this.textBoxSumaZaPlashtane.Text}', '{this.radioButton9Percent.Text}', '{this.comboBoxClients.SelectedIndex + 1}', '{this.comboBoxClients.SelectedIndex + 1}')";
                }
                MySqlConnection cn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("invoices");
                da.Fill(table);
                Invoice_ProductData();
                MessageBox.Show("Invoice has been successfully saved to the database!");
                RefreshPage();
            }
        }

        private void AddProductToDataGrid()
        {
            string query = $"Select products.PRODUCTID as \"Код\",products.PRODUCTNAME as \"Продукт\", products.PRODUCTMEASURE as \"Мярка\", QUANTITY as \"Количество\", PRODUCT_PROD_CENA as \"Ед. цена\" FROM products where (products.PRODUCTNAME = '{this.comboBoxProducts.SelectedValue}');";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("products, invoice");
            da.Fill(table);
            cn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                this.dataGridViewAddedProduct.Rows.Add(dr["Код"], dr["Продукт"], dr["Мярка"], dr["Количество"], dr["Ед. цена"]);
                double sum = 0;
                double dds = 0;
                for (int i = 0; i < this.dataGridViewAddedProduct.Rows.Count - 1; i++)
                {
                    sum += Convert.ToDouble(this.dataGridViewAddedProduct.Rows[i].Cells[4].Value);
                }
                this.textBoxDanuchnaOsnova.Text = sum.ToString();
                if (this.radioButton20Percent.Checked)
                {
                    dds = sum * 0.2;
                    this.textBoxDDS.Text = dds.ToString();

                }
                else
                {
                    dds = sum * 0.09;
                    this.textBoxDDS.Text = dds.ToString();
                }
                this.textBoxSumaZaPlashtane.Text = (sum + dds).ToString();
            }
        }

        private void NextItem(DataGridView dataGridView) //https://www.c-sharpcorner.com/forums/how-to-go-next-row-in-datagridview
        {
            dataGridView.CurrentRow.Selected = true;
            if (dataGridView.Rows.Count >= 1)
            {
                int index = dataGridView.CurrentRow.Index + 1;
                if (index >= -1 && index < dataGridView.Rows.Count)
                {
                    dataGridView.CurrentCell = dataGridView[0, index];
                    dataGridView.Rows[index].Selected = true;
                }
            }
        }

        private void PreviousItem(DataGridView dataGridView)
        {
            dataGridView.CurrentRow.Selected = true;
            if (dataGridView.Rows.Count >= 1)
            {
                int index = dataGridView.CurrentRow.Index - 1;
                if (index > -1 && index < dataGridView.Rows.Count)
                {
                    dataGridView.CurrentCell = dataGridView[0, index];
                    dataGridView.Rows[index].Selected = true;
                }
            }
        }

        private void FirstItem(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count >= 1)
            {
                dataGridView.CurrentCell = dataGridView[0, 0];
                dataGridView.Rows[0].Selected = true;
            }
        }

        private void LastItem(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count >= 1)
            {
                dataGridView.CurrentCell = dataGridView[dataGridView.Rows.Count - 2, dataGridView.Rows.Count - 2];
                dataGridView.Rows[dataGridView.Rows.Count - 2].Selected = true;
            }
        }

    }
}
