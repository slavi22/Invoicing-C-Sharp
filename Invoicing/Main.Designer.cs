namespace Invoicing
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxInvoice = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxNumberInvoice = new TextBox();
            labelDate = new Label();
            labelNumber = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            tabControlNavigation = new TabControl();
            tabPageNewInvoice = new TabPage();
            buttonExit = new Button();
            buttonCancel = new Button();
            buttonSavePdf = new Button();
            buttonPrintDialog = new Button();
            buttonPrint = new Button();
            buttonPrintPreview = new Button();
            checkBoxOriginal = new CheckBox();
            buttonDelInvoice = new Button();
            buttonEditInvoice = new Button();
            buttonSave = new Button();
            buttonDeleteRow = new Button();
            buttonRefresh = new Button();
            buttonNewInvoice = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            buttonLastRecord = new Button();
            buttonForward = new Button();
            buttonBack = new Button();
            buttonFirstRecord = new Button();
            groupBoxNachinNaPlashtane = new GroupBox();
            comboBoxNachinNaPlashtane = new ComboBox();
            groupBoxProducts = new GroupBox();
            buttonAddProduct = new Button();
            comboBoxProducts = new ComboBox();
            groupBoxClients = new GroupBox();
            comboBoxClients = new ComboBox();
            groupBoxPoluchatel = new GroupBox();
            radioButton1 = new RadioButton();
            radioButtonMOL = new RadioButton();
            labelDDS = new Label();
            label4 = new Label();
            groupBoxTotal = new GroupBox();
            textBoxSumaZaPlashtane = new TextBox();
            textBoxDDS = new TextBox();
            label3 = new Label();
            radioButton9Percent = new RadioButton();
            radioButton20Percent = new RadioButton();
            label1 = new Label();
            textBoxDanuchnaOsnova = new TextBox();
            label2 = new Label();
            dataGridViewAddedProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tabPageInvoices = new TabPage();
            dataGridViewSelectedProduct = new DataGridView();
            dataGridViewAllInvoices = new DataGridView();
            tabPageProducts = new TabPage();
            textBoxProductsProdajnaCena = new TextBox();
            textBoxProductsDostavnaCena = new TextBox();
            textBoxProductsMqrka = new TextBox();
            textBoxProductsNaimenovanie = new TextBox();
            dataGridViewProducts = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            buttonProductsExit = new Button();
            buttonProductsDelete = new Button();
            buttonProductsSave = new Button();
            buttonProductsCancel = new Button();
            buttonProductsEdit = new Button();
            buttonProductsInsert = new Button();
            buttonProductsLastItem = new Button();
            buttonProductsNext = new Button();
            buttonProductsPrevious = new Button();
            buttonProductsFirstItem = new Button();
            textBoxProductsKodNaProdukta = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabPageCustomers = new TabPage();
            dataGridViewCustomers = new DataGridView();
            textBoxCustomersMOL = new TextBox();
            textBoxCustomersAddress = new TextBox();
            textBoxCustomersZDDS = new TextBox();
            textBoxCustomersEIK = new TextBox();
            textBoxCustomersClient = new TextBox();
            buttonCustomersExit = new Button();
            buttonCustomersDelete = new Button();
            buttonCustomersSave = new Button();
            buttonCustomersCancel = new Button();
            buttonCustomersEdit = new Button();
            buttonCustomersInsert = new Button();
            buttonCustomersLastItem = new Button();
            buttonCustomersNext = new Button();
            buttonCustomersPrevious = new Button();
            buttonCustomersFirstItem = new Button();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBoxInvoice.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabControlNavigation.SuspendLayout();
            tabPageNewInvoice.SuspendLayout();
            groupBoxNachinNaPlashtane.SuspendLayout();
            groupBoxProducts.SuspendLayout();
            groupBoxClients.SuspendLayout();
            groupBoxPoluchatel.SuspendLayout();
            groupBoxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddedProduct).BeginInit();
            tabPageInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelectedProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllInvoices).BeginInit();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInvoice
            // 
            groupBoxInvoice.Controls.Add(dateTimePicker1);
            groupBoxInvoice.Controls.Add(textBoxNumberInvoice);
            groupBoxInvoice.Controls.Add(labelDate);
            groupBoxInvoice.Controls.Add(labelNumber);
            groupBoxInvoice.Enabled = false;
            groupBoxInvoice.Location = new Point(17, 24);
            groupBoxInvoice.Name = "groupBoxInvoice";
            groupBoxInvoice.Size = new Size(313, 148);
            groupBoxInvoice.TabIndex = 0;
            groupBoxInvoice.TabStop = false;
            groupBoxInvoice.Text = "Invoice";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(94, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBoxNumberInvoice
            // 
            textBoxNumberInvoice.Location = new Point(94, 27);
            textBoxNumberInvoice.Name = "textBoxNumberInvoice";
            textBoxNumberInvoice.Size = new Size(100, 23);
            textBoxNumberInvoice.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(24, 60);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(24, 30);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(51, 15);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "Number";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1107, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // tabControlNavigation
            // 
            tabControlNavigation.Controls.Add(tabPageNewInvoice);
            tabControlNavigation.Controls.Add(tabPageInvoices);
            tabControlNavigation.Controls.Add(tabPageProducts);
            tabControlNavigation.Controls.Add(tabPageCustomers);
            tabControlNavigation.Location = new Point(10, 26);
            tabControlNavigation.Name = "tabControlNavigation";
            tabControlNavigation.SelectedIndex = 0;
            tabControlNavigation.Size = new Size(1083, 616);
            tabControlNavigation.TabIndex = 2;
            // 
            // tabPageNewInvoice
            // 
            tabPageNewInvoice.BackColor = SystemColors.Control;
            tabPageNewInvoice.Controls.Add(buttonExit);
            tabPageNewInvoice.Controls.Add(buttonCancel);
            tabPageNewInvoice.Controls.Add(buttonSavePdf);
            tabPageNewInvoice.Controls.Add(buttonPrintDialog);
            tabPageNewInvoice.Controls.Add(buttonPrint);
            tabPageNewInvoice.Controls.Add(buttonPrintPreview);
            tabPageNewInvoice.Controls.Add(checkBoxOriginal);
            tabPageNewInvoice.Controls.Add(buttonDelInvoice);
            tabPageNewInvoice.Controls.Add(buttonEditInvoice);
            tabPageNewInvoice.Controls.Add(buttonSave);
            tabPageNewInvoice.Controls.Add(buttonDeleteRow);
            tabPageNewInvoice.Controls.Add(buttonRefresh);
            tabPageNewInvoice.Controls.Add(buttonNewInvoice);
            tabPageNewInvoice.Controls.Add(buttonSearch);
            tabPageNewInvoice.Controls.Add(textBoxSearch);
            tabPageNewInvoice.Controls.Add(buttonLastRecord);
            tabPageNewInvoice.Controls.Add(buttonForward);
            tabPageNewInvoice.Controls.Add(buttonBack);
            tabPageNewInvoice.Controls.Add(buttonFirstRecord);
            tabPageNewInvoice.Controls.Add(groupBoxNachinNaPlashtane);
            tabPageNewInvoice.Controls.Add(groupBoxProducts);
            tabPageNewInvoice.Controls.Add(groupBoxClients);
            tabPageNewInvoice.Controls.Add(groupBoxPoluchatel);
            tabPageNewInvoice.Controls.Add(labelDDS);
            tabPageNewInvoice.Controls.Add(label4);
            tabPageNewInvoice.Controls.Add(groupBoxTotal);
            tabPageNewInvoice.Controls.Add(dataGridViewAddedProduct);
            tabPageNewInvoice.Controls.Add(groupBoxInvoice);
            tabPageNewInvoice.Location = new Point(4, 24);
            tabPageNewInvoice.Name = "tabPageNewInvoice";
            tabPageNewInvoice.Padding = new Padding(3);
            tabPageNewInvoice.Size = new Size(1075, 588);
            tabPageNewInvoice.TabIndex = 0;
            tabPageNewInvoice.Text = "New Invoice";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(880, 545);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(138, 23);
            buttonExit.TabIndex = 30;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(880, 472);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(138, 23);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSavePdf
            // 
            buttonSavePdf.Location = new Point(880, 443);
            buttonSavePdf.Name = "buttonSavePdf";
            buttonSavePdf.Size = new Size(138, 23);
            buttonSavePdf.TabIndex = 28;
            buttonSavePdf.Text = "Save PDF";
            buttonSavePdf.UseVisualStyleBackColor = true;
            buttonSavePdf.Click += buttonSavePdf_Click;
            // 
            // buttonPrintDialog
            // 
            buttonPrintDialog.Location = new Point(880, 414);
            buttonPrintDialog.Name = "buttonPrintDialog";
            buttonPrintDialog.Size = new Size(138, 23);
            buttonPrintDialog.TabIndex = 27;
            buttonPrintDialog.Text = "Print Dialog";
            buttonPrintDialog.UseVisualStyleBackColor = true;
            buttonPrintDialog.Click += buttonPrintDialog_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(880, 385);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(138, 23);
            buttonPrint.TabIndex = 26;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonPrintPreview
            // 
            buttonPrintPreview.Location = new Point(880, 356);
            buttonPrintPreview.Name = "buttonPrintPreview";
            buttonPrintPreview.Size = new Size(138, 23);
            buttonPrintPreview.TabIndex = 25;
            buttonPrintPreview.Text = "Print Preview";
            buttonPrintPreview.UseVisualStyleBackColor = true;
            buttonPrintPreview.Click += buttonPrintPreview_Click;
            // 
            // checkBoxOriginal
            // 
            checkBoxOriginal.AutoSize = true;
            checkBoxOriginal.Location = new Point(855, 331);
            checkBoxOriginal.Name = "checkBoxOriginal";
            checkBoxOriginal.Size = new Size(81, 19);
            checkBoxOriginal.TabIndex = 24;
            checkBoxOriginal.Text = "Оригинал";
            checkBoxOriginal.UseVisualStyleBackColor = true;
            // 
            // buttonDelInvoice
            // 
            buttonDelInvoice.Location = new Point(880, 288);
            buttonDelInvoice.Name = "buttonDelInvoice";
            buttonDelInvoice.Size = new Size(138, 23);
            buttonDelInvoice.TabIndex = 23;
            buttonDelInvoice.Text = "Del Invoice";
            buttonDelInvoice.UseVisualStyleBackColor = true;
            // 
            // buttonEditInvoice
            // 
            buttonEditInvoice.Location = new Point(880, 255);
            buttonEditInvoice.Name = "buttonEditInvoice";
            buttonEditInvoice.Size = new Size(138, 23);
            buttonEditInvoice.TabIndex = 22;
            buttonEditInvoice.Text = "Edit Invoice";
            buttonEditInvoice.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(880, 222);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(138, 23);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDeleteRow
            // 
            buttonDeleteRow.Location = new Point(880, 184);
            buttonDeleteRow.Name = "buttonDeleteRow";
            buttonDeleteRow.Size = new Size(138, 23);
            buttonDeleteRow.TabIndex = 20;
            buttonDeleteRow.Text = "Delete Row";
            buttonDeleteRow.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(880, 149);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(138, 23);
            buttonRefresh.TabIndex = 19;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonNewInvoice
            // 
            buttonNewInvoice.Location = new Point(880, 115);
            buttonNewInvoice.Name = "buttonNewInvoice";
            buttonNewInvoice.Size = new Size(138, 23);
            buttonNewInvoice.TabIndex = 18;
            buttonNewInvoice.Text = "New Invoice";
            buttonNewInvoice.UseVisualStyleBackColor = true;
            buttonNewInvoice.Click += buttonNewInvoice_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(988, 75);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(30, 23);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "S";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(880, 76);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(100, 23);
            textBoxSearch.TabIndex = 12;
            // 
            // buttonLastRecord
            // 
            buttonLastRecord.Location = new Point(988, 37);
            buttonLastRecord.Name = "buttonLastRecord";
            buttonLastRecord.Size = new Size(30, 23);
            buttonLastRecord.TabIndex = 16;
            buttonLastRecord.Text = ">|";
            buttonLastRecord.UseVisualStyleBackColor = true;
            // 
            // buttonForward
            // 
            buttonForward.Location = new Point(952, 37);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(30, 23);
            buttonForward.TabIndex = 15;
            buttonForward.Text = ">";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(916, 37);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(30, 23);
            buttonBack.TabIndex = 14;
            buttonBack.Text = "<";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonFirstRecord
            // 
            buttonFirstRecord.Location = new Point(880, 37);
            buttonFirstRecord.Name = "buttonFirstRecord";
            buttonFirstRecord.Size = new Size(30, 23);
            buttonFirstRecord.TabIndex = 13;
            buttonFirstRecord.Text = "|<";
            buttonFirstRecord.UseVisualStyleBackColor = true;
            // 
            // groupBoxNachinNaPlashtane
            // 
            groupBoxNachinNaPlashtane.Controls.Add(comboBoxNachinNaPlashtane);
            groupBoxNachinNaPlashtane.Location = new Point(354, 178);
            groupBoxNachinNaPlashtane.Name = "groupBoxNachinNaPlashtane";
            groupBoxNachinNaPlashtane.Size = new Size(295, 70);
            groupBoxNachinNaPlashtane.TabIndex = 6;
            groupBoxNachinNaPlashtane.TabStop = false;
            groupBoxNachinNaPlashtane.Text = "Начин на плащане";
            // 
            // comboBoxNachinNaPlashtane
            // 
            comboBoxNachinNaPlashtane.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNachinNaPlashtane.FormattingEnabled = true;
            comboBoxNachinNaPlashtane.Items.AddRange(new object[] { "Наложен платеж", "Чрез карта", "Банков превод" });
            comboBoxNachinNaPlashtane.Location = new Point(6, 33);
            comboBoxNachinNaPlashtane.Name = "comboBoxNachinNaPlashtane";
            comboBoxNachinNaPlashtane.Size = new Size(277, 23);
            comboBoxNachinNaPlashtane.TabIndex = 5;
            // 
            // groupBoxProducts
            // 
            groupBoxProducts.Controls.Add(buttonAddProduct);
            groupBoxProducts.Controls.Add(comboBoxProducts);
            groupBoxProducts.Location = new Point(17, 255);
            groupBoxProducts.Name = "groupBoxProducts";
            groupBoxProducts.Size = new Size(632, 70);
            groupBoxProducts.TabIndex = 6;
            groupBoxProducts.TabStop = false;
            groupBoxProducts.Text = "Products";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(538, 41);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(88, 23);
            buttonAddProduct.TabIndex = 6;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(12, 16);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(614, 23);
            comboBoxProducts.TabIndex = 5;
            // 
            // groupBoxClients
            // 
            groupBoxClients.Controls.Add(comboBoxClients);
            groupBoxClients.Location = new Point(17, 178);
            groupBoxClients.Name = "groupBoxClients";
            groupBoxClients.Size = new Size(331, 70);
            groupBoxClients.TabIndex = 5;
            groupBoxClients.TabStop = false;
            groupBoxClients.Text = "Clients";
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(12, 33);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(301, 23);
            comboBoxClients.TabIndex = 5;
            // 
            // groupBoxPoluchatel
            // 
            groupBoxPoluchatel.Controls.Add(radioButton1);
            groupBoxPoluchatel.Controls.Add(radioButtonMOL);
            groupBoxPoluchatel.Location = new Point(655, 163);
            groupBoxPoluchatel.Name = "groupBoxPoluchatel";
            groupBoxPoluchatel.Size = new Size(130, 115);
            groupBoxPoluchatel.TabIndex = 12;
            groupBoxPoluchatel.TabStop = false;
            groupBoxPoluchatel.Text = "Получател";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 19);
            radioButton1.TabIndex = 1;
            radioButton1.Text = ".....";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMOL
            // 
            radioButtonMOL.AutoSize = true;
            radioButtonMOL.Checked = true;
            radioButtonMOL.Location = new Point(18, 41);
            radioButtonMOL.Name = "radioButtonMOL";
            radioButtonMOL.Size = new Size(53, 19);
            radioButtonMOL.TabIndex = 0;
            radioButtonMOL.TabStop = true;
            radioButtonMOL.Text = "МОЛ";
            radioButtonMOL.UseVisualStyleBackColor = true;
            // 
            // labelDDS
            // 
            labelDDS.AutoSize = true;
            labelDDS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelDDS.Location = new Point(673, 80);
            labelDDS.Name = "labelDDS";
            labelDDS.Size = new Size(112, 32);
            labelDDS.TabIndex = 6;
            labelDDS.Text = "labelDDS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(673, 37);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 5;
            label4.Text = "ДДС";
            // 
            // groupBoxTotal
            // 
            groupBoxTotal.Controls.Add(textBoxSumaZaPlashtane);
            groupBoxTotal.Controls.Add(textBoxDDS);
            groupBoxTotal.Controls.Add(label3);
            groupBoxTotal.Controls.Add(radioButton9Percent);
            groupBoxTotal.Controls.Add(radioButton20Percent);
            groupBoxTotal.Controls.Add(label1);
            groupBoxTotal.Controls.Add(textBoxDanuchnaOsnova);
            groupBoxTotal.Controls.Add(label2);
            groupBoxTotal.Location = new Point(336, 24);
            groupBoxTotal.Name = "groupBoxTotal";
            groupBoxTotal.Size = new Size(313, 148);
            groupBoxTotal.TabIndex = 4;
            groupBoxTotal.TabStop = false;
            groupBoxTotal.Text = "Total";
            // 
            // textBoxSumaZaPlashtane
            // 
            textBoxSumaZaPlashtane.Location = new Point(207, 99);
            textBoxSumaZaPlashtane.Name = "textBoxSumaZaPlashtane";
            textBoxSumaZaPlashtane.Size = new Size(100, 23);
            textBoxSumaZaPlashtane.TabIndex = 11;
            // 
            // textBoxDDS
            // 
            textBoxDDS.Location = new Point(207, 60);
            textBoxDDS.Name = "textBoxDDS";
            textBoxDDS.Size = new Size(100, 23);
            textBoxDDS.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 99);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 9;
            label3.Text = "Сума за плащане";
            // 
            // radioButton9Percent
            // 
            radioButton9Percent.AutoSize = true;
            radioButton9Percent.Location = new Point(126, 56);
            radioButton9Percent.Name = "radioButton9Percent";
            radioButton9Percent.Size = new Size(41, 19);
            radioButton9Percent.TabIndex = 8;
            radioButton9Percent.Text = "9%";
            radioButton9Percent.UseVisualStyleBackColor = true;
            radioButton9Percent.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton20Percent
            // 
            radioButton20Percent.AutoSize = true;
            radioButton20Percent.Checked = true;
            radioButton20Percent.Location = new Point(73, 56);
            radioButton20Percent.Name = "radioButton20Percent";
            radioButton20Percent.Size = new Size(47, 19);
            radioButton20Percent.TabIndex = 7;
            radioButton20Percent.TabStop = true;
            radioButton20Percent.Text = "20%";
            radioButton20Percent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "ДДС";
            // 
            // textBoxDanuchnaOsnova
            // 
            textBoxDanuchnaOsnova.Location = new Point(207, 26);
            textBoxDanuchnaOsnova.Name = "textBoxDanuchnaOsnova";
            textBoxDanuchnaOsnova.Size = new Size(100, 23);
            textBoxDanuchnaOsnova.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 30);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Данъчна основа";
            // 
            // dataGridViewAddedProduct
            // 
            dataGridViewAddedProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddedProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewAddedProduct.Location = new Point(6, 331);
            dataGridViewAddedProduct.Name = "dataGridViewAddedProduct";
            dataGridViewAddedProduct.RowHeadersWidth = 51;
            dataGridViewAddedProduct.RowTemplate.Height = 25;
            dataGridViewAddedProduct.Size = new Size(843, 259);
            dataGridViewAddedProduct.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Код";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Продукт";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Мярка";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Количество";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Ед. цена";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // tabPageInvoices
            // 
            tabPageInvoices.BackColor = SystemColors.Control;
            tabPageInvoices.Controls.Add(dataGridViewSelectedProduct);
            tabPageInvoices.Controls.Add(dataGridViewAllInvoices);
            tabPageInvoices.Location = new Point(4, 24);
            tabPageInvoices.Margin = new Padding(3, 2, 3, 2);
            tabPageInvoices.Name = "tabPageInvoices";
            tabPageInvoices.Padding = new Padding(3, 2, 3, 2);
            tabPageInvoices.Size = new Size(1075, 588);
            tabPageInvoices.TabIndex = 3;
            tabPageInvoices.Text = "Invoices";
            // 
            // dataGridViewSelectedProduct
            // 
            dataGridViewSelectedProduct.AllowUserToAddRows = false;
            dataGridViewSelectedProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSelectedProduct.Location = new Point(5, 380);
            dataGridViewSelectedProduct.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSelectedProduct.Name = "dataGridViewSelectedProduct";
            dataGridViewSelectedProduct.ReadOnly = true;
            dataGridViewSelectedProduct.RowHeadersWidth = 51;
            dataGridViewSelectedProduct.RowTemplate.Height = 29;
            dataGridViewSelectedProduct.Size = new Size(1066, 206);
            dataGridViewSelectedProduct.TabIndex = 1;
            // 
            // dataGridViewAllInvoices
            // 
            dataGridViewAllInvoices.AllowUserToAddRows = false;
            dataGridViewAllInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllInvoices.Location = new Point(5, 4);
            dataGridViewAllInvoices.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAllInvoices.Name = "dataGridViewAllInvoices";
            dataGridViewAllInvoices.ReadOnly = true;
            dataGridViewAllInvoices.RowHeadersWidth = 51;
            dataGridViewAllInvoices.RowTemplate.Height = 29;
            dataGridViewAllInvoices.Size = new Size(1066, 370);
            dataGridViewAllInvoices.TabIndex = 0;
            dataGridViewAllInvoices.CellClick += dataGridViewAllInvoices_CellClick;
            // 
            // tabPageProducts
            // 
            tabPageProducts.BackColor = SystemColors.Control;
            tabPageProducts.Controls.Add(textBoxProductsProdajnaCena);
            tabPageProducts.Controls.Add(textBoxProductsDostavnaCena);
            tabPageProducts.Controls.Add(textBoxProductsMqrka);
            tabPageProducts.Controls.Add(textBoxProductsNaimenovanie);
            tabPageProducts.Controls.Add(dataGridViewProducts);
            tabPageProducts.Controls.Add(buttonProductsExit);
            tabPageProducts.Controls.Add(buttonProductsDelete);
            tabPageProducts.Controls.Add(buttonProductsSave);
            tabPageProducts.Controls.Add(buttonProductsCancel);
            tabPageProducts.Controls.Add(buttonProductsEdit);
            tabPageProducts.Controls.Add(buttonProductsInsert);
            tabPageProducts.Controls.Add(buttonProductsLastItem);
            tabPageProducts.Controls.Add(buttonProductsNext);
            tabPageProducts.Controls.Add(buttonProductsPrevious);
            tabPageProducts.Controls.Add(buttonProductsFirstItem);
            tabPageProducts.Controls.Add(textBoxProductsKodNaProdukta);
            tabPageProducts.Controls.Add(label9);
            tabPageProducts.Controls.Add(label8);
            tabPageProducts.Controls.Add(label7);
            tabPageProducts.Controls.Add(label6);
            tabPageProducts.Controls.Add(label5);
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1075, 588);
            tabPageProducts.TabIndex = 2;
            tabPageProducts.Text = "Products";
            // 
            // textBoxProductsProdajnaCena
            // 
            textBoxProductsProdajnaCena.Location = new Point(172, 180);
            textBoxProductsProdajnaCena.Margin = new Padding(3, 2, 3, 2);
            textBoxProductsProdajnaCena.Name = "textBoxProductsProdajnaCena";
            textBoxProductsProdajnaCena.Size = new Size(412, 23);
            textBoxProductsProdajnaCena.TabIndex = 20;
            textBoxProductsProdajnaCena.Text = "eee";
            // 
            // textBoxProductsDostavnaCena
            // 
            textBoxProductsDostavnaCena.Location = new Point(172, 145);
            textBoxProductsDostavnaCena.Margin = new Padding(3, 2, 3, 2);
            textBoxProductsDostavnaCena.Name = "textBoxProductsDostavnaCena";
            textBoxProductsDostavnaCena.Size = new Size(412, 23);
            textBoxProductsDostavnaCena.TabIndex = 19;
            textBoxProductsDostavnaCena.Text = "ddd";
            // 
            // textBoxProductsMqrka
            // 
            textBoxProductsMqrka.Location = new Point(172, 110);
            textBoxProductsMqrka.Margin = new Padding(3, 2, 3, 2);
            textBoxProductsMqrka.Name = "textBoxProductsMqrka";
            textBoxProductsMqrka.Size = new Size(412, 23);
            textBoxProductsMqrka.TabIndex = 18;
            textBoxProductsMqrka.Text = "ccc";
            // 
            // textBoxProductsNaimenovanie
            // 
            textBoxProductsNaimenovanie.Location = new Point(172, 71);
            textBoxProductsNaimenovanie.Margin = new Padding(3, 2, 3, 2);
            textBoxProductsNaimenovanie.Name = "textBoxProductsNaimenovanie";
            textBoxProductsNaimenovanie.Size = new Size(412, 23);
            textBoxProductsNaimenovanie.TabIndex = 17;
            textBoxProductsNaimenovanie.Text = "bbb";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10 });
            dataGridViewProducts.Location = new Point(5, 213);
            dataGridViewProducts.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new Size(911, 373);
            dataGridViewProducts.TabIndex = 16;
            // 
            // Column6
            // 
            Column6.HeaderText = "Код";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 175;
            // 
            // Column7
            // 
            Column7.HeaderText = "Наименование на продукта";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 300;
            // 
            // Column8
            // 
            Column8.HeaderText = "Мярка";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Дост. цена";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Прод. цена";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // buttonProductsExit
            // 
            buttonProductsExit.Location = new Point(921, 436);
            buttonProductsExit.Margin = new Padding(3, 2, 3, 2);
            buttonProductsExit.Name = "buttonProductsExit";
            buttonProductsExit.Size = new Size(142, 22);
            buttonProductsExit.TabIndex = 15;
            buttonProductsExit.Text = "Exit";
            buttonProductsExit.UseVisualStyleBackColor = true;
            buttonProductsExit.Click += buttonExit_Click;
            // 
            // buttonProductsDelete
            // 
            buttonProductsDelete.Location = new Point(921, 197);
            buttonProductsDelete.Margin = new Padding(3, 2, 3, 2);
            buttonProductsDelete.Name = "buttonProductsDelete";
            buttonProductsDelete.Size = new Size(142, 22);
            buttonProductsDelete.TabIndex = 14;
            buttonProductsDelete.Text = "Delete";
            buttonProductsDelete.UseVisualStyleBackColor = true;
            buttonProductsDelete.Click += buttonProductsDelete_Click;
            // 
            // buttonProductsSave
            // 
            buttonProductsSave.Location = new Point(921, 171);
            buttonProductsSave.Margin = new Padding(3, 2, 3, 2);
            buttonProductsSave.Name = "buttonProductsSave";
            buttonProductsSave.Size = new Size(142, 22);
            buttonProductsSave.TabIndex = 13;
            buttonProductsSave.Text = "Save";
            buttonProductsSave.UseVisualStyleBackColor = true;
            buttonProductsSave.Click += buttonProductsSave_Click;
            // 
            // buttonProductsCancel
            // 
            buttonProductsCancel.Location = new Point(921, 145);
            buttonProductsCancel.Margin = new Padding(3, 2, 3, 2);
            buttonProductsCancel.Name = "buttonProductsCancel";
            buttonProductsCancel.Size = new Size(142, 22);
            buttonProductsCancel.TabIndex = 12;
            buttonProductsCancel.Text = "Cancel";
            buttonProductsCancel.UseVisualStyleBackColor = true;
            buttonProductsCancel.Click += buttonProductsCancel_Click;
            // 
            // buttonProductsEdit
            // 
            buttonProductsEdit.Location = new Point(921, 118);
            buttonProductsEdit.Margin = new Padding(3, 2, 3, 2);
            buttonProductsEdit.Name = "buttonProductsEdit";
            buttonProductsEdit.Size = new Size(142, 22);
            buttonProductsEdit.TabIndex = 11;
            buttonProductsEdit.Text = "Edit";
            buttonProductsEdit.UseVisualStyleBackColor = true;
            buttonProductsEdit.Click += buttonProductsEdit_Click;
            // 
            // buttonProductsInsert
            // 
            buttonProductsInsert.Location = new Point(921, 92);
            buttonProductsInsert.Margin = new Padding(3, 2, 3, 2);
            buttonProductsInsert.Name = "buttonProductsInsert";
            buttonProductsInsert.Size = new Size(142, 22);
            buttonProductsInsert.TabIndex = 10;
            buttonProductsInsert.Text = "Insert";
            buttonProductsInsert.UseVisualStyleBackColor = true;
            buttonProductsInsert.Click += buttonProductsInsert_Click;
            // 
            // buttonProductsLastItem
            // 
            buttonProductsLastItem.Location = new Point(1032, 38);
            buttonProductsLastItem.Margin = new Padding(3, 2, 3, 2);
            buttonProductsLastItem.Name = "buttonProductsLastItem";
            buttonProductsLastItem.Size = new Size(32, 22);
            buttonProductsLastItem.TabIndex = 9;
            buttonProductsLastItem.Text = ">|";
            buttonProductsLastItem.UseVisualStyleBackColor = true;
            buttonProductsLastItem.Click += buttonProductsLastItem_Click;
            // 
            // buttonProductsNext
            // 
            buttonProductsNext.Location = new Point(995, 38);
            buttonProductsNext.Margin = new Padding(3, 2, 3, 2);
            buttonProductsNext.Name = "buttonProductsNext";
            buttonProductsNext.Size = new Size(32, 22);
            buttonProductsNext.TabIndex = 8;
            buttonProductsNext.Text = ">";
            buttonProductsNext.UseVisualStyleBackColor = true;
            buttonProductsNext.Click += buttonProductsNext_Click;
            // 
            // buttonProductsPrevious
            // 
            buttonProductsPrevious.Location = new Point(958, 38);
            buttonProductsPrevious.Margin = new Padding(3, 2, 3, 2);
            buttonProductsPrevious.Name = "buttonProductsPrevious";
            buttonProductsPrevious.Size = new Size(32, 22);
            buttonProductsPrevious.TabIndex = 7;
            buttonProductsPrevious.Text = "<";
            buttonProductsPrevious.UseVisualStyleBackColor = true;
            buttonProductsPrevious.Click += buttonProductsPrevious_Click;
            // 
            // buttonProductsFirstItem
            // 
            buttonProductsFirstItem.Location = new Point(921, 38);
            buttonProductsFirstItem.Margin = new Padding(3, 2, 3, 2);
            buttonProductsFirstItem.Name = "buttonProductsFirstItem";
            buttonProductsFirstItem.Size = new Size(32, 22);
            buttonProductsFirstItem.TabIndex = 6;
            buttonProductsFirstItem.Text = "|<";
            buttonProductsFirstItem.UseVisualStyleBackColor = true;
            buttonProductsFirstItem.Click += buttonProductsFirstItem_Click;
            // 
            // textBoxProductsKodNaProdukta
            // 
            textBoxProductsKodNaProdukta.Location = new Point(172, 38);
            textBoxProductsKodNaProdukta.Margin = new Padding(3, 2, 3, 2);
            textBoxProductsKodNaProdukta.Name = "textBoxProductsKodNaProdukta";
            textBoxProductsKodNaProdukta.Size = new Size(412, 23);
            textBoxProductsKodNaProdukta.TabIndex = 5;
            textBoxProductsKodNaProdukta.Text = "aaa";
            textBoxProductsKodNaProdukta.TextChanged += textBoxProductsKodNaProdukta_TextChanged;
            textBoxProductsKodNaProdukta.Validating += textBoxProductsKodNaProdukta_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 180);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 4;
            label9.Text = "Продажна цена *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 145);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 3;
            label8.Text = "Доставна цена *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 110);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 2;
            label7.Text = "Мярка *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 71);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 1;
            label6.Text = "Наименование *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 38);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 0;
            label5.Text = "Код на продукта * ";
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.BackColor = SystemColors.Control;
            tabPageCustomers.Controls.Add(dataGridViewCustomers);
            tabPageCustomers.Controls.Add(textBoxCustomersMOL);
            tabPageCustomers.Controls.Add(textBoxCustomersAddress);
            tabPageCustomers.Controls.Add(textBoxCustomersZDDS);
            tabPageCustomers.Controls.Add(textBoxCustomersEIK);
            tabPageCustomers.Controls.Add(textBoxCustomersClient);
            tabPageCustomers.Controls.Add(buttonCustomersExit);
            tabPageCustomers.Controls.Add(buttonCustomersDelete);
            tabPageCustomers.Controls.Add(buttonCustomersSave);
            tabPageCustomers.Controls.Add(buttonCustomersCancel);
            tabPageCustomers.Controls.Add(buttonCustomersEdit);
            tabPageCustomers.Controls.Add(buttonCustomersInsert);
            tabPageCustomers.Controls.Add(buttonCustomersLastItem);
            tabPageCustomers.Controls.Add(buttonCustomersNext);
            tabPageCustomers.Controls.Add(buttonCustomersPrevious);
            tabPageCustomers.Controls.Add(buttonCustomersFirstItem);
            tabPageCustomers.Controls.Add(label15);
            tabPageCustomers.Controls.Add(label14);
            tabPageCustomers.Controls.Add(label12);
            tabPageCustomers.Controls.Add(label11);
            tabPageCustomers.Controls.Add(label10);
            tabPageCustomers.Location = new Point(4, 24);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(1075, 588);
            tabPageCustomers.TabIndex = 1;
            tabPageCustomers.Text = "Customers";
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(6, 224);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.RowTemplate.Height = 25;
            dataGridViewCustomers.Size = new Size(884, 358);
            dataGridViewCustomers.TabIndex = 32;
            // 
            // textBoxCustomersMOL
            // 
            textBoxCustomersMOL.Location = new Point(169, 156);
            textBoxCustomersMOL.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomersMOL.Name = "textBoxCustomersMOL";
            textBoxCustomersMOL.Size = new Size(412, 23);
            textBoxCustomersMOL.TabIndex = 31;
            textBoxCustomersMOL.Text = "fff";
            // 
            // textBoxCustomersAddress
            // 
            textBoxCustomersAddress.Location = new Point(169, 118);
            textBoxCustomersAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomersAddress.Name = "textBoxCustomersAddress";
            textBoxCustomersAddress.Size = new Size(412, 23);
            textBoxCustomersAddress.TabIndex = 30;
            textBoxCustomersAddress.Text = "eee";
            // 
            // textBoxCustomersZDDS
            // 
            textBoxCustomersZDDS.Location = new Point(169, 81);
            textBoxCustomersZDDS.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomersZDDS.Name = "textBoxCustomersZDDS";
            textBoxCustomersZDDS.Size = new Size(412, 23);
            textBoxCustomersZDDS.TabIndex = 28;
            textBoxCustomersZDDS.Text = "ccc";
            // 
            // textBoxCustomersEIK
            // 
            textBoxCustomersEIK.Location = new Point(169, 49);
            textBoxCustomersEIK.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomersEIK.Name = "textBoxCustomersEIK";
            textBoxCustomersEIK.Size = new Size(412, 23);
            textBoxCustomersEIK.TabIndex = 27;
            textBoxCustomersEIK.Text = "bbb";
            // 
            // textBoxCustomersClient
            // 
            textBoxCustomersClient.Location = new Point(169, 16);
            textBoxCustomersClient.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomersClient.Name = "textBoxCustomersClient";
            textBoxCustomersClient.Size = new Size(412, 23);
            textBoxCustomersClient.TabIndex = 26;
            textBoxCustomersClient.Text = "aaa";
            // 
            // buttonCustomersExit
            // 
            buttonCustomersExit.Location = new Point(897, 417);
            buttonCustomersExit.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersExit.Name = "buttonCustomersExit";
            buttonCustomersExit.Size = new Size(142, 22);
            buttonCustomersExit.TabIndex = 25;
            buttonCustomersExit.Text = "Exit";
            buttonCustomersExit.UseVisualStyleBackColor = true;
            // 
            // buttonCustomersDelete
            // 
            buttonCustomersDelete.Location = new Point(896, 178);
            buttonCustomersDelete.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersDelete.Name = "buttonCustomersDelete";
            buttonCustomersDelete.Size = new Size(142, 22);
            buttonCustomersDelete.TabIndex = 24;
            buttonCustomersDelete.Text = "Delete";
            buttonCustomersDelete.UseVisualStyleBackColor = true;
            buttonCustomersDelete.Click += buttonCustomersDelete_Click;
            // 
            // buttonCustomersSave
            // 
            buttonCustomersSave.Location = new Point(896, 152);
            buttonCustomersSave.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersSave.Name = "buttonCustomersSave";
            buttonCustomersSave.Size = new Size(142, 22);
            buttonCustomersSave.TabIndex = 23;
            buttonCustomersSave.Text = "Save";
            buttonCustomersSave.UseVisualStyleBackColor = true;
            buttonCustomersSave.Click += buttonCustomersSave_Click;
            // 
            // buttonCustomersCancel
            // 
            buttonCustomersCancel.Location = new Point(896, 126);
            buttonCustomersCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersCancel.Name = "buttonCustomersCancel";
            buttonCustomersCancel.Size = new Size(142, 22);
            buttonCustomersCancel.TabIndex = 22;
            buttonCustomersCancel.Text = "Cancel";
            buttonCustomersCancel.UseVisualStyleBackColor = true;
            buttonCustomersCancel.Click += buttonCustomersCancel_Click;
            // 
            // buttonCustomersEdit
            // 
            buttonCustomersEdit.Location = new Point(896, 99);
            buttonCustomersEdit.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersEdit.Name = "buttonCustomersEdit";
            buttonCustomersEdit.Size = new Size(142, 22);
            buttonCustomersEdit.TabIndex = 21;
            buttonCustomersEdit.Text = "Edit";
            buttonCustomersEdit.UseVisualStyleBackColor = true;
            buttonCustomersEdit.Click += buttonCustomersEdit_Click;
            // 
            // buttonCustomersInsert
            // 
            buttonCustomersInsert.Location = new Point(896, 73);
            buttonCustomersInsert.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersInsert.Name = "buttonCustomersInsert";
            buttonCustomersInsert.Size = new Size(142, 22);
            buttonCustomersInsert.TabIndex = 20;
            buttonCustomersInsert.Text = "Insert";
            buttonCustomersInsert.UseVisualStyleBackColor = true;
            buttonCustomersInsert.Click += buttonCustomersInsert_Click;
            // 
            // buttonCustomersLastItem
            // 
            buttonCustomersLastItem.Location = new Point(1007, 19);
            buttonCustomersLastItem.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersLastItem.Name = "buttonCustomersLastItem";
            buttonCustomersLastItem.Size = new Size(32, 22);
            buttonCustomersLastItem.TabIndex = 19;
            buttonCustomersLastItem.Text = ">|";
            buttonCustomersLastItem.UseVisualStyleBackColor = true;
            // 
            // buttonCustomersNext
            // 
            buttonCustomersNext.Location = new Point(970, 19);
            buttonCustomersNext.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersNext.Name = "buttonCustomersNext";
            buttonCustomersNext.Size = new Size(32, 22);
            buttonCustomersNext.TabIndex = 18;
            buttonCustomersNext.Text = ">";
            buttonCustomersNext.UseVisualStyleBackColor = true;
            // 
            // buttonCustomersPrevious
            // 
            buttonCustomersPrevious.Location = new Point(933, 19);
            buttonCustomersPrevious.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersPrevious.Name = "buttonCustomersPrevious";
            buttonCustomersPrevious.Size = new Size(32, 22);
            buttonCustomersPrevious.TabIndex = 17;
            buttonCustomersPrevious.Text = "<";
            buttonCustomersPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonCustomersFirstItem
            // 
            buttonCustomersFirstItem.Location = new Point(896, 19);
            buttonCustomersFirstItem.Margin = new Padding(3, 2, 3, 2);
            buttonCustomersFirstItem.Name = "buttonCustomersFirstItem";
            buttonCustomersFirstItem.Size = new Size(32, 22);
            buttonCustomersFirstItem.TabIndex = 16;
            buttonCustomersFirstItem.Text = "|<";
            buttonCustomersFirstItem.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 156);
            label15.Name = "label15";
            label15.Size = new Size(35, 15);
            label15.TabIndex = 5;
            label15.Text = "МОЛ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(47, 126);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 4;
            label14.Text = "Адрес";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 89);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 2;
            label12.Text = "ИН по ЗДДС";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 52);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 1;
            label11.Text = "ЕИК";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 19);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 0;
            label10.Text = "Клиент";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 646);
            Controls.Add(tabControlNavigation);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1123, 685);
            MinimumSize = new Size(1123, 685);
            Name = "Main";
            Text = "Form1";
            Load += radioButton_CheckedChanged;
            groupBoxInvoice.ResumeLayout(false);
            groupBoxInvoice.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlNavigation.ResumeLayout(false);
            tabPageNewInvoice.ResumeLayout(false);
            tabPageNewInvoice.PerformLayout();
            groupBoxNachinNaPlashtane.ResumeLayout(false);
            groupBoxProducts.ResumeLayout(false);
            groupBoxClients.ResumeLayout(false);
            groupBoxPoluchatel.ResumeLayout(false);
            groupBoxPoluchatel.PerformLayout();
            groupBoxTotal.ResumeLayout(false);
            groupBoxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddedProduct).EndInit();
            tabPageInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelectedProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllInvoices).EndInit();
            tabPageProducts.ResumeLayout(false);
            tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabPageCustomers.ResumeLayout(false);
            tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInvoice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TabControl tabControlNavigation;
        private TabPage tabPageNewInvoice;
        private Label labelDate;
        private Label labelNumber;
        private DataGridView dataGridViewAddedProduct;
        private TextBox textBoxNumberInvoice;
        private Label labelDDS;
        private Label label4;
        private GroupBox groupBoxTotal;
        private TextBox textBoxSumaZaPlashtane;
        private TextBox textBoxDDS;
        private Label label3;
        private RadioButton radioButton9Percent;
        private RadioButton radioButton20Percent;
        private Label label1;
        private TextBox textBoxDanuchnaOsnova;
        private Label label2;
        private TabPage tabPageCustomers;
        private GroupBox groupBoxPoluchatel;
        private RadioButton radioButton1;
        private RadioButton radioButtonMOL;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Button buttonLastRecord;
        private Button buttonForward;
        private Button buttonBack;
        private Button buttonFirstRecord;
        private GroupBox groupBoxNachinNaPlashtane;
        private ComboBox comboBoxNachinNaPlashtane;
        private GroupBox groupBoxProducts;
        private GroupBox groupBoxClients;
        private ComboBox comboBoxClients;
        private Button buttonNewInvoice;
        private Button buttonExit;
        private Button buttonCancel;
        private Button buttonSavePdf;
        private Button buttonPrintDialog;
        private Button buttonPrint;
        private Button buttonPrintPreview;
        private CheckBox checkBoxOriginal;
        private Button buttonDelInvoice;
        private Button buttonEditInvoice;
        private Button buttonSave;
        private Button buttonDeleteRow;
        private Button buttonRefresh;
        private TabPage tabPageProducts;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonProductsFirstItem;
        private Button buttonProductsDelete;
        private Button buttonProductsSave;
        private Button buttonProductsCancel;
        private Button buttonProductsEdit;
        private Button buttonProductsInsert;
        private Button buttonProductsLastItem;
        private Button buttonProductsNext;
        private Button buttonProductsPrevious;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button buttonProductsExit;
        private TextBox textBoxProductsProdajnaCena;
        private TextBox textBoxProductsDostavnaCena;
        private TextBox textBoxProductsMqrka;
        private TextBox textBoxProductsNaimenovanie;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        internal DataGridView dataGridViewProducts;
        internal ComboBox comboBoxProducts;
        internal TextBox textBoxProductsKodNaProdukta;
        private ErrorProvider errorProvider1;
        private Button buttonAddProduct;
        private TabPage tabPageInvoices;
        private DataGridView dataGridViewSelectedProduct;
        private DataGridView dataGridViewAllInvoices;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label11;
        internal TextBox textBoxCustomersClient;
        private Button buttonCustomersExit;
        private Button buttonCustomersDelete;
        private Button buttonCustomersSave;
        private Button buttonCustomersCancel;
        private Button buttonCustomersEdit;
        private Button buttonCustomersInsert;
        private Button buttonCustomersLastItem;
        private Button buttonCustomersNext;
        private Button buttonCustomersPrevious;
        private Button buttonCustomersFirstItem;
        internal TextBox textBoxCustomersMOL;
        internal TextBox textBoxCustomersAddress;
        internal TextBox textBoxCustomersZDDS;
        internal TextBox textBoxCustomersEIK;
        internal DataGridView dataGridViewCustomers;
    }
}