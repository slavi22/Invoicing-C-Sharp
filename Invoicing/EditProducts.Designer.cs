namespace Invoicing
{
    partial class EditProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForm2KodNaProdukta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxForm2Naimenovanie = new System.Windows.Forms.TextBox();
            this.textBoxForm2Mqrka = new System.Windows.Forms.TextBox();
            this.textBoxForm2DostavnaCena = new System.Windows.Forms.TextBox();
            this.textBoxForm2ProdajnaCena = new System.Windows.Forms.TextBox();
            this.buttonForm2SaveData = new System.Windows.Forms.Button();
            this.buttonForm2Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код на продукта * ";
            // 
            // textBoxForm2KodNaProdukta
            // 
            this.textBoxForm2KodNaProdukta.Location = new System.Drawing.Point(132, 40);
            this.textBoxForm2KodNaProdukta.Name = "textBoxForm2KodNaProdukta";
            this.textBoxForm2KodNaProdukta.Size = new System.Drawing.Size(170, 23);
            this.textBoxForm2KodNaProdukta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мярка *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Доставна цена *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Продажна цена *";
            // 
            // textBoxForm2Naimenovanie
            // 
            this.textBoxForm2Naimenovanie.Location = new System.Drawing.Point(132, 68);
            this.textBoxForm2Naimenovanie.Name = "textBoxForm2Naimenovanie";
            this.textBoxForm2Naimenovanie.Size = new System.Drawing.Size(170, 23);
            this.textBoxForm2Naimenovanie.TabIndex = 6;
            // 
            // textBoxForm2Mqrka
            // 
            this.textBoxForm2Mqrka.Location = new System.Drawing.Point(132, 94);
            this.textBoxForm2Mqrka.Name = "textBoxForm2Mqrka";
            this.textBoxForm2Mqrka.Size = new System.Drawing.Size(170, 23);
            this.textBoxForm2Mqrka.TabIndex = 7;
            // 
            // textBoxForm2DostavnaCena
            // 
            this.textBoxForm2DostavnaCena.Location = new System.Drawing.Point(132, 123);
            this.textBoxForm2DostavnaCena.Name = "textBoxForm2DostavnaCena";
            this.textBoxForm2DostavnaCena.Size = new System.Drawing.Size(170, 23);
            this.textBoxForm2DostavnaCena.TabIndex = 8;
            // 
            // textBoxForm2ProdajnaCena
            // 
            this.textBoxForm2ProdajnaCena.Location = new System.Drawing.Point(132, 152);
            this.textBoxForm2ProdajnaCena.Name = "textBoxForm2ProdajnaCena";
            this.textBoxForm2ProdajnaCena.Size = new System.Drawing.Size(170, 23);
            this.textBoxForm2ProdajnaCena.TabIndex = 9;
            // 
            // buttonForm2SaveData
            // 
            this.buttonForm2SaveData.Location = new System.Drawing.Point(49, 240);
            this.buttonForm2SaveData.Name = "buttonForm2SaveData";
            this.buttonForm2SaveData.Size = new System.Drawing.Size(97, 23);
            this.buttonForm2SaveData.TabIndex = 10;
            this.buttonForm2SaveData.Text = "Save data";
            this.buttonForm2SaveData.UseVisualStyleBackColor = true;
            this.buttonForm2SaveData.Click += new System.EventHandler(this.buttonForm2SaveData_Click);
            // 
            // buttonForm2Exit
            // 
            this.buttonForm2Exit.Location = new System.Drawing.Point(205, 240);
            this.buttonForm2Exit.Name = "buttonForm2Exit";
            this.buttonForm2Exit.Size = new System.Drawing.Size(97, 23);
            this.buttonForm2Exit.TabIndex = 11;
            this.buttonForm2Exit.Text = "Exit";
            this.buttonForm2Exit.UseVisualStyleBackColor = true;
            this.buttonForm2Exit.Click += new System.EventHandler(this.buttonForm2Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 319);
            this.Controls.Add(this.buttonForm2Exit);
            this.Controls.Add(this.buttonForm2SaveData);
            this.Controls.Add(this.textBoxForm2ProdajnaCena);
            this.Controls.Add(this.textBoxForm2DostavnaCena);
            this.Controls.Add(this.textBoxForm2Mqrka);
            this.Controls.Add(this.textBoxForm2Naimenovanie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxForm2KodNaProdukta);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        internal TextBox textBoxForm2KodNaProdukta;
        internal TextBox textBoxForm2Naimenovanie;
        internal TextBox textBoxForm2Mqrka;
        internal TextBox textBoxForm2DostavnaCena;
        internal TextBox textBoxForm2ProdajnaCena;
        private Button buttonForm2SaveData;
        private Button buttonForm2Exit;
    }
}