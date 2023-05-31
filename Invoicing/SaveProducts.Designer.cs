namespace Invoicing
{
    partial class SaveProducts
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
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonSaveSelectedRow = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Има промени в базата\r\nЖелаете ли да ги запазите?\r\n";
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(42, 85);
            this.buttonSaveAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(104, 22);
            this.buttonSaveAll.TabIndex = 1;
            this.buttonSaveAll.Text = "Запази всичко";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // buttonSaveSelectedRow
            // 
            this.buttonSaveSelectedRow.Location = new System.Drawing.Point(164, 85);
            this.buttonSaveSelectedRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveSelectedRow.Name = "buttonSaveSelectedRow";
            this.buttonSaveSelectedRow.Size = new System.Drawing.Size(191, 22);
            this.buttonSaveSelectedRow.TabIndex = 2;
            this.buttonSaveSelectedRow.Text = "Запази само избрания ред";
            this.buttonSaveSelectedRow.UseVisualStyleBackColor = true;
            this.buttonSaveSelectedRow.Click += new System.EventHandler(this.buttonSaveSelectedRow_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(380, 85);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 22);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отказ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 150);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveSelectedRow);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(522, 189);
            this.MinimumSize = new System.Drawing.Size(522, 189);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonSaveAll;
        private Button buttonSaveSelectedRow;
        private Button buttonCancel;
    }
}