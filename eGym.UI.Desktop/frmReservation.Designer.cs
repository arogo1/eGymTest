namespace eGym.UI.Desktop
{
    partial class frmReservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rtxbDescription = new System.Windows.Forms.RichTextBox();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klijent";
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(27, 209);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 29;
            this.dgvReservations.Size = new System.Drawing.Size(458, 401);
            this.dgvReservations.TabIndex = 3;
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(391, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(174, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(311, 27);
            this.dtpDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vrsta treninga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Opis";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(673, 46);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(266, 27);
            this.txtClient.TabIndex = 11;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(673, 98);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(266, 27);
            this.dtpFrom.TabIndex = 12;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(673, 162);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(266, 27);
            this.dtpTo.TabIndex = 13;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tezinski",
            "Funkcionali",
            "Aerobik",
            "Kardio"});
            this.cmbType.Location = new System.Drawing.Point(673, 238);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(266, 28);
            this.cmbType.TabIndex = 14;
            // 
            // rtxbDescription
            // 
            this.rtxbDescription.Location = new System.Drawing.Point(673, 318);
            this.rtxbDescription.Name = "rtxbDescription";
            this.rtxbDescription.ReadOnly = true;
            this.rtxbDescription.Size = new System.Drawing.Size(266, 192);
            this.rtxbDescription.TabIndex = 15;
            this.rtxbDescription.Text = "";
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(673, 572);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(104, 38);
            this.btnDecline.TabIndex = 16;
            this.btnDecline.Text = "Odbij";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(837, 572);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(102, 38);
            this.btnAccept.TabIndex = 17;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 644);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.rtxbDescription);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReservation";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvReservations;
        private Button btnSearch;
        private DateTimePicker dtpDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtClient;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private ComboBox cmbType;
        private RichTextBox rtxbDescription;
        private Button btnDecline;
        private Button btnAccept;
    }
}