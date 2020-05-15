namespace Stockmgmt
{
    partial class Clients
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
            this.components = new System.ComponentModel.Container();
            this.ClientPhone_txtbox = new System.Windows.Forms.TextBox();
            this.ClientWebsite_txtbox = new System.Windows.Forms.TextBox();
            this.ClientEmail_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.ClientMobile_txtbox = new System.Windows.Forms.TextBox();
            this.ClientFax_txtbox = new System.Windows.Forms.TextBox();
            this.ClientName_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perFaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perWebsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockmgmtDBDataSet = new Stockmgmt.StockmgmtDBDataSet();
            this.personTableAdapter = new Stockmgmt.StockmgmtDBDataSetTableAdapters.PersonTableAdapter();
            this.client_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmgmtDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPhone_txtbox
            // 
            this.ClientPhone_txtbox.Location = new System.Drawing.Point(180, 88);
            this.ClientPhone_txtbox.Name = "ClientPhone_txtbox";
            this.ClientPhone_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ClientPhone_txtbox.TabIndex = 42;
            // 
            // ClientWebsite_txtbox
            // 
            this.ClientWebsite_txtbox.Location = new System.Drawing.Point(490, 35);
            this.ClientWebsite_txtbox.Name = "ClientWebsite_txtbox";
            this.ClientWebsite_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ClientWebsite_txtbox.TabIndex = 41;
            // 
            // ClientEmail_txtbox
            // 
            this.ClientEmail_txtbox.Location = new System.Drawing.Point(490, 80);
            this.ClientEmail_txtbox.Name = "ClientEmail_txtbox";
            this.ClientEmail_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ClientEmail_txtbox.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(389, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(388, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Website :";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Maroon;
            this.Addbtn.Location = new System.Drawing.Point(731, 78);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(90, 30);
            this.Addbtn.TabIndex = 37;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // ClientMobile_txtbox
            // 
            this.ClientMobile_txtbox.Location = new System.Drawing.Point(180, 124);
            this.ClientMobile_txtbox.Name = "ClientMobile_txtbox";
            this.ClientMobile_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ClientMobile_txtbox.TabIndex = 36;
            // 
            // ClientFax_txtbox
            // 
            this.ClientFax_txtbox.Location = new System.Drawing.Point(490, 124);
            this.ClientFax_txtbox.Name = "ClientFax_txtbox";
            this.ClientFax_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ClientFax_txtbox.TabIndex = 34;
            // 
            // ClientName_txtbox
            // 
            this.ClientName_txtbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientName_txtbox.Location = new System.Drawing.Point(265, 38);
            this.ClientName_txtbox.Name = "ClientName_txtbox";
            this.ClientName_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ClientName_txtbox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(389, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "fax :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(52, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mobile no :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(61, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Phone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Client\'s name :";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Maroon;
            this.updateBtn.Location = new System.Drawing.Point(630, 79);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(95, 29);
            this.updateBtn.TabIndex = 43;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.ForeColor = System.Drawing.Color.Maroon;
            this.loadbtn.Location = new System.Drawing.Point(692, 40);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(75, 29);
            this.loadbtn.TabIndex = 44;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perMobileDataGridViewTextBoxColumn,
            this.perPhoneDataGridViewTextBoxColumn,
            this.perFaxDataGridViewTextBoxColumn,
            this.perEmailDataGridViewTextBoxColumn,
            this.perWebsiteDataGridViewTextBoxColumn,
            this.perTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 199);
            this.dataGridView1.TabIndex = 45;
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "Per_Id";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "Per_Id";
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "Per_Name";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "Per_Name";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perMobileDataGridViewTextBoxColumn
            // 
            this.perMobileDataGridViewTextBoxColumn.DataPropertyName = "Per_Mobile";
            this.perMobileDataGridViewTextBoxColumn.HeaderText = "Per_Mobile";
            this.perMobileDataGridViewTextBoxColumn.Name = "perMobileDataGridViewTextBoxColumn";
            // 
            // perPhoneDataGridViewTextBoxColumn
            // 
            this.perPhoneDataGridViewTextBoxColumn.DataPropertyName = "Per_Phone";
            this.perPhoneDataGridViewTextBoxColumn.HeaderText = "Per_Phone";
            this.perPhoneDataGridViewTextBoxColumn.Name = "perPhoneDataGridViewTextBoxColumn";
            // 
            // perFaxDataGridViewTextBoxColumn
            // 
            this.perFaxDataGridViewTextBoxColumn.DataPropertyName = "Per_Fax";
            this.perFaxDataGridViewTextBoxColumn.HeaderText = "Per_Fax";
            this.perFaxDataGridViewTextBoxColumn.Name = "perFaxDataGridViewTextBoxColumn";
            // 
            // perEmailDataGridViewTextBoxColumn
            // 
            this.perEmailDataGridViewTextBoxColumn.DataPropertyName = "Per_Email";
            this.perEmailDataGridViewTextBoxColumn.HeaderText = "Per_Email";
            this.perEmailDataGridViewTextBoxColumn.Name = "perEmailDataGridViewTextBoxColumn";
            // 
            // perWebsiteDataGridViewTextBoxColumn
            // 
            this.perWebsiteDataGridViewTextBoxColumn.DataPropertyName = "Per_Website";
            this.perWebsiteDataGridViewTextBoxColumn.HeaderText = "Per_Website";
            this.perWebsiteDataGridViewTextBoxColumn.Name = "perWebsiteDataGridViewTextBoxColumn";
            // 
            // perTypeDataGridViewTextBoxColumn
            // 
            this.perTypeDataGridViewTextBoxColumn.DataPropertyName = "Per_Type";
            this.perTypeDataGridViewTextBoxColumn.HeaderText = "Per_Type";
            this.perTypeDataGridViewTextBoxColumn.Name = "perTypeDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.stockmgmtDBDataSet;
            // 
            // stockmgmtDBDataSet
            // 
            this.stockmgmtDBDataSet.DataSetName = "StockmgmtDBDataSet";
            this.stockmgmtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // client_comboBox1
            // 
            this.client_comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.client_comboBox1.FormattingEnabled = true;
            this.client_comboBox1.Location = new System.Drawing.Point(138, 39);
            this.client_comboBox1.Name = "client_comboBox1";
            this.client_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.client_comboBox1.TabIndex = 46;
            this.client_comboBox1.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(256, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Add new Client...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(138, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Select Client...";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client_comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.ClientPhone_txtbox);
            this.Controls.Add(this.ClientWebsite_txtbox);
            this.Controls.Add(this.ClientEmail_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ClientMobile_txtbox);
            this.Controls.Add(this.ClientFax_txtbox);
            this.Controls.Add(this.ClientName_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmgmtDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientPhone_txtbox;
        private System.Windows.Forms.TextBox ClientWebsite_txtbox;
        private System.Windows.Forms.TextBox ClientEmail_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox ClientMobile_txtbox;
        private System.Windows.Forms.TextBox ClientFax_txtbox;
        private System.Windows.Forms.TextBox ClientName_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StockmgmtDBDataSet stockmgmtDBDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private StockmgmtDBDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perFaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perWebsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox client_comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}