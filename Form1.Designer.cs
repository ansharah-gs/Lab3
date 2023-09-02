namespace Lab3
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            dgvInvoice = new DataGridView();
            lblaccNumber = new Label();
            textBoxAccountNo = new TextBox();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxLastName = new TextBox();
            textBoxUsedKwh = new TextBox();
            btn_AddCustomer = new Button();
            button1 = new Button();
            btn_DeleteInvoice = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btn_CloseApp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(460, 300);
            dataGridView1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(364, 237);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Customer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvInvoice
            // 
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(741, 214);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowTemplate.Height = 25;
            dgvInvoice.Size = new Size(605, 464);
            dgvInvoice.TabIndex = 3;
            // 
            // lblaccNumber
            // 
            lblaccNumber.AutoSize = true;
            lblaccNumber.Location = new Point(50, 71);
            lblaccNumber.Name = "lblaccNumber";
            lblaccNumber.Size = new Size(99, 15);
            lblaccNumber.TabIndex = 4;
            lblaccNumber.Text = "Account Number";
            // 
            // textBoxAccountNo
            // 
            textBoxAccountNo.Location = new Point(214, 63);
            textBoxAccountNo.Name = "textBoxAccountNo";
            textBoxAccountNo.Size = new Size(293, 23);
            textBoxAccountNo.TabIndex = 5;
            textBoxAccountNo.KeyPress += textBoxAccountNo_KeyPress;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(214, 121);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(293, 23);
            textBoxFirstName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 125);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 179);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 109);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Used KWH";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(214, 179);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(293, 23);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxUsedKwh
            // 
            textBoxUsedKwh.Location = new Point(963, 106);
            textBoxUsedKwh.Name = "textBoxUsedKwh";
            textBoxUsedKwh.Size = new Size(293, 23);
            textBoxUsedKwh.TabIndex = 11;
            textBoxUsedKwh.KeyPress += textBoxUsedKwh_KeyPress;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.Location = new Point(47, 237);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(143, 23);
            btn_AddCustomer.TabIndex = 12;
            btn_AddCustomer.Text = "Add Customer";
            btn_AddCustomer.UseVisualStyleBackColor = true;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(741, 157);
            button1.Name = "button1";
            button1.Size = new Size(184, 23);
            button1.TabIndex = 13;
            button1.Text = "ADD INVOICE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_DeleteInvoice
            // 
            btn_DeleteInvoice.Location = new Point(1209, 157);
            btn_DeleteInvoice.Name = "btn_DeleteInvoice";
            btn_DeleteInvoice.Size = new Size(137, 23);
            btn_DeleteInvoice.TabIndex = 14;
            btn_DeleteInvoice.Text = "DELETE INVOICE";
            btn_DeleteInvoice.UseVisualStyleBackColor = true;
            btn_DeleteInvoice.Click += btn_DeleteInvoice_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 37);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 81);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 125);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 17;
            label6.Text = "label6";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(52, 572);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 164);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 123);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 20;
            label9.Text = "Average Bill";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 80);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 19;
            label8.Text = "Total Consumption";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 37);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 18;
            label7.Text = "Count";
            // 
            // btn_CloseApp
            // 
            btn_CloseApp.Location = new Point(1242, 24);
            btn_CloseApp.Name = "btn_CloseApp";
            btn_CloseApp.Size = new Size(104, 23);
            btn_CloseApp.TabIndex = 19;
            btn_CloseApp.Text = "Close App";
            btn_CloseApp.UseVisualStyleBackColor = true;
            btn_CloseApp.Click += btn_CloseApp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 760);
            Controls.Add(btn_CloseApp);
            Controls.Add(groupBox1);
            Controls.Add(btn_DeleteInvoice);
            Controls.Add(button1);
            Controls.Add(btn_AddCustomer);
            Controls.Add(textBoxUsedKwh);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxAccountNo);
            Controls.Add(lblaccNumber);
            Controls.Add(dgvInvoice);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Electricity Bill Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private DataGridView dgvInvoice;
        private Label lblaccNumber;
        private TextBox textBoxAccountNo;
        private TextBox textBoxFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLastName;
        private TextBox textBoxUsedKwh;
        private Button btn_AddCustomer;
        private Button button1;
        private Button btn_DeleteInvoice;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btn_CloseApp;
    }
}