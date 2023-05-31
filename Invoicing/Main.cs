using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using IniParser;
using IniParser.Model;

namespace Invoicing
{
    public partial class Main : Form
    {
        private int clickCountProducts = 0;
        private int clickCountCustomers = 0;
        MySqlConnection conn;
        FileIniDataParser parser = new FileIniDataParser();
        IniData data;
        public string connection;
        public string fakNo = "";
        public string cusNo = "";
        public Main()
        {
            data = parser.ReadFile("../../../../connection.ini");
            connection = $"server={data["credentials"]["server"]};uid={data["credentials"]["uid"]};pwd={data["credentials"]["pwd"]};database={data["credentials"]["database"]}";
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            conn = new MySqlConnection(connection);
            conn.Open();
            InitNewInvoice(false);
            InitProductsTab(false);
            InitCustomersTab(false);
            ProductsDataGridViewOnLoad();
            CustomersDataGridViewOnLoad();
            ProductsComboBoxOnLoad();
            NextInvoiceNumber();
            NextCustomerID();
            InvoiceNumberToString(fakNo);
            DataGridViewAllInvoicesOnLoad();

            this.prnDialog = new System.Windows.Forms.PrintDialog();

            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();

            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrnDocument_PrintPage);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
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
                this.labelDDS.Text = this.radioButton20Percent.Text;
                this.textBoxDDS.Text = dds.ToString();

            }
            else
            {
                dds = sum * 0.09;
                this.labelDDS.Text = this.radioButton9Percent.Text;
                this.textBoxDDS.Text = dds.ToString();
            }
            this.textBoxSumaZaPlashtane.Text = (sum + dds).ToString();
        }

        private void buttonNewInvoice_Click(object sender, EventArgs e)
        {
            this.textBoxDanuchnaOsnova.Enabled = false;
            this.textBoxDDS.Enabled = false;
            this.textBoxSumaZaPlashtane.Enabled = false;
            this.buttonRefresh.Enabled = true;
            this.textBoxNumberInvoice.Enabled = false;
            this.buttonDeleteRow.Enabled = true;
            this.buttonSave.Enabled = true;
            this.buttonCancel.Enabled = true;
            this.dataGridViewAddedProduct.Enabled = true;
            this.groupBoxInvoice.Enabled = true;
            this.groupBoxTotal.Enabled = true;
            this.groupBoxClients.Enabled = true;
            this.groupBoxNachinNaPlashtane.Enabled = true;
            this.groupBoxPoluchatel.Enabled = true;
            this.groupBoxProducts.Enabled = true;
            this.checkBoxOriginal.Enabled = true;
            AddClients();
            this.comboBoxProducts.SelectedIndex = -1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.buttonRefresh.Enabled = false;
            this.buttonDeleteRow.Enabled = false;
            this.buttonSave.Enabled = false;
            this.buttonCancel.Enabled = false;
            this.dataGridViewAddedProduct.Enabled = false;
            this.groupBoxInvoice.Enabled = false;
            this.groupBoxTotal.Enabled = false;
            this.groupBoxClients.Enabled = false;
            this.groupBoxNachinNaPlashtane.Enabled = false;
            this.groupBoxPoluchatel.Enabled = false;
            this.groupBoxProducts.Enabled = false;
            this.checkBoxOriginal.Enabled = false;
            this.comboBoxProducts.SelectedIndex = -1;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonProductsSave_Click(object sender, EventArgs e)
        {
            ProductsSaveToComboBox();

        }

        private void buttonCustomersSave_Click(object sender, EventArgs e)
        {
            CustomersSaveAll();
        }

        private void buttonProductsInsert_Click(object sender, EventArgs e)
        {
            clickCountProducts++;
            if (clickCountProducts > 2)
            {
                clickCountProducts = 2;
            }
            if (clickCountProducts == 1)
            {
                InitProductsTab(true);
            }
            if (ValidateChildren() == true)
            {
                if (clickCountProducts == 2)
                {
                    ProductsAddToDataGrid();
                }
            }

        }

        private void buttonCustomersInsert_Click(object sender, EventArgs e)
        {
            clickCountCustomers++;
            if (clickCountCustomers > 2)
            {
                clickCountCustomers = 2;
            }
            if (clickCountCustomers == 1)
            {
                InitCustomersTab(true);
            }
            if (ValidateChildren() == true)
            {
                if (clickCountCustomers == 2)
                {
                    CustomersAddToDataGrid();
                }
            }
        }

        private void buttonCustomersCancel_Click(object sender, EventArgs e)
        {
            clickCountCustomers = 0;
            InitCustomersTab(false);
        }


        private void buttonProductsDelete_Click(object sender, EventArgs e)
        {
            DeleteProductFromRow();
            ProductsComboBoxOnLoad();
        }

        private void buttonProductsCancel_Click(object sender, EventArgs e)
        {
            clickCountProducts = 0;
            InitProductsTab(false);

        }

        private void buttonProductsEdit_Click(object sender, EventArgs e)
        {
            EditProducts form2 = new EditProducts(this);
            form2.Show();
            form2.textBoxForm2KodNaProdukta.Text = this.dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
            form2.textBoxForm2Naimenovanie.Text = this.dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            form2.textBoxForm2Mqrka.Text = this.dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            form2.textBoxForm2DostavnaCena.Text = this.dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();
            form2.textBoxForm2ProdajnaCena.Text = this.dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonProductsNext_Click(object sender, EventArgs e)
        {
            NextItem(this.dataGridViewProducts);
        }


        private void buttonProductsPrevious_Click(object sender, EventArgs e)
        {
            PreviousItem(this.dataGridViewProducts);
        }

        private void buttonProductsFirstItem_Click(object sender, EventArgs e)
        {
            FirstItem(this.dataGridViewProducts);
        }

        private void buttonProductsLastItem_Click(object sender, EventArgs e)
        {
            LastItem(this.dataGridViewProducts);
        }

        private void textBoxProductsKodNaProdukta_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!int.TryParse(tb.Text, out _))
            {
                e.Cancel = false;
                tb.Focus();
                errorProvider1.SetError(tb, "Позволени са само цифри в това поле!");
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void textBoxProductsKodNaProdukta_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (ValidateChildren())
            {
                errorProvider1.SetError(tb, "");
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductToDataGrid();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveToInvoice();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }


        private void dataGridViewAllInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedInvoiceProductInfo();
        }

        private void buttonCustomersEdit_Click(object sender, EventArgs e)
        {
            EditCustomers customers = new EditCustomers(this);
            customers.Show();
            customers.textBoxEditClientsClient.Text = this.dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
            customers.textBoxEditClientsEIK.Text = this.dataGridViewCustomers.CurrentRow.Cells[3].Value.ToString();
            customers.textBoxEditClientsZDDS.Text = this.dataGridViewCustomers.CurrentRow.Cells[4].Value.ToString();
            customers.textBoxEditClientsMOL.Text = this.dataGridViewCustomers.CurrentRow.Cells[2].Value.ToString();
            customers.textBoxEditClientsAddress.Text = this.dataGridViewCustomers.CurrentRow.Cells[1].Value.ToString();
            //customers.textBoxEditClientsMOL.Text = this.dataGridViewCustomers.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonCustomersDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomerFromRow();
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            GetCustomerData();
            GetSellerData();
            DisplayInvoice();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrintDialog_Click(object sender, EventArgs e)
        {
            DisplayDialog();
        }

        private void buttonSavePdf_Click(object sender, EventArgs e)
        {

        }

        private void buttonForward_Click(object sender, EventArgs e)
        {

        }
    }
}