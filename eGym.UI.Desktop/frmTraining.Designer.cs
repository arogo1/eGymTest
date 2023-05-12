namespace eGym.UI.Desktop
{
    partial class frmTraining
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
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateNewTraining = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Nedjelja",
            "Ponedjeljak",
            "Utorak",
            "Srijeda",
            "Cetvrtak",
            "Petak",
            "Subota"});
            this.cmbDay.Location = new System.Drawing.Point(1170, 205);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(320, 28);
            this.cmbDay.TabIndex = 56;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1388, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 36);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(1170, 285);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(320, 197);
            this.rtxtDescription.TabIndex = 54;
            this.rtxtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1170, 122);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(320, 27);
            this.txtName.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1066, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1066, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Dan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1066, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Klijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1228, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Plan treninga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 27);
            this.txtSearch.TabIndex = 45;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(12, 122);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.Size = new System.Drawing.Size(428, 453);
            this.dgvAccount.TabIndex = 44;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // dgvTraining
            // 
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Location = new System.Drawing.Point(568, 122);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.RowHeadersWidth = 51;
            this.dgvTraining.RowTemplate.Height = 29;
            this.dgvTraining.Size = new System.Drawing.Size(428, 453);
            this.dgvTraining.TabIndex = 57;
            this.dgvTraining.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraining_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Lista postojecih treninga";
            // 
            // btnCreateNewTraining
            // 
            this.btnCreateNewTraining.Location = new System.Drawing.Point(875, 60);
            this.btnCreateNewTraining.Name = "btnCreateNewTraining";
            this.btnCreateNewTraining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateNewTraining.Size = new System.Drawing.Size(121, 29);
            this.btnCreateNewTraining.TabIndex = 59;
            this.btnCreateNewTraining.Text = "Kreiraj novi";
            this.btnCreateNewTraining.UseVisualStyleBackColor = true;
            this.btnCreateNewTraining.Click += new System.EventHandler(this.btnCreateNewTraining_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1262, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 36);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 615);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateNewTraining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTraining);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAccount);
            this.Name = "frmTraining";
            this.Text = "Plan Treninga";
            this.Load += new System.EventHandler(this.frmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbDay;
        private Button btnSave;
        private RichTextBox rtxtDescription;
        private TextBox txtName;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvAccount;
        private DataGridView dgvTraining;
        private Label label5;
        private Button btnCreateNewTraining;
        private Button btnDelete;
    }
}