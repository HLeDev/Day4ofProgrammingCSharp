
namespace Week5Day2Assignment1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpChecking = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.comboAcctType = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblCityState = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAcctType = new System.Windows.Forms.Label();
            this.gridChkAcct = new System.Windows.Forms.DataGridView();
            this.lblChkInfo = new System.Windows.Forms.Label();
            this.lblSavingsInfo = new System.Windows.Forms.Label();
            this.gridSavings = new System.Windows.Forms.DataGridView();
            this.lblChkTotal = new System.Windows.Forms.Label();
            this.txtChkSum = new System.Windows.Forms.TextBox();
            this.btnDispChk = new System.Windows.Forms.Button();
            this.btnDispSavings = new System.Windows.Forms.Button();
            this.txtSavingsSum = new System.Windows.Forms.TextBox();
            this.lblSavingsTotal = new System.Windows.Forms.Label();
            this.comboTransfer = new System.Windows.Forms.ComboBox();
            this.lblTrans = new System.Windows.Forms.Label();
            this.grpChecking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChkAcct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSavings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeader.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(560, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(426, 49);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "POG UNION BANK";
            // 
            // grpChecking
            // 
            this.grpChecking.BackColor = System.Drawing.Color.Transparent;
            this.grpChecking.Controls.Add(this.comboTransfer);
            this.grpChecking.Controls.Add(this.lblTrans);
            this.grpChecking.Controls.Add(this.btnGenerate);
            this.grpChecking.Controls.Add(this.txtID);
            this.grpChecking.Controls.Add(this.txtAmount);
            this.grpChecking.Controls.Add(this.txtPhone);
            this.grpChecking.Controls.Add(this.txtCityState);
            this.grpChecking.Controls.Add(this.txtLN);
            this.grpChecking.Controls.Add(this.txtFN);
            this.grpChecking.Controls.Add(this.comboAcctType);
            this.grpChecking.Controls.Add(this.lblAmount);
            this.grpChecking.Controls.Add(this.lblPhoneNum);
            this.grpChecking.Controls.Add(this.lblCityState);
            this.grpChecking.Controls.Add(this.lblLName);
            this.grpChecking.Controls.Add(this.lblFName);
            this.grpChecking.Controls.Add(this.lblID);
            this.grpChecking.Controls.Add(this.lblAcctType);
            this.grpChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChecking.Location = new System.Drawing.Point(12, 61);
            this.grpChecking.Name = "grpChecking";
            this.grpChecking.Size = new System.Drawing.Size(759, 364);
            this.grpChecking.TabIndex = 1;
            this.grpChecking.TabStop = false;
            this.grpChecking.Text = "Customer Information";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerate.Location = new System.Drawing.Point(213, 287);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(327, 63);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(143, 86);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 35);
            this.txtID.TabIndex = 13;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(548, 235);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(205, 35);
            this.txtAmount.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(548, 160);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(205, 35);
            this.txtPhone.TabIndex = 11;
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(548, 88);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(205, 35);
            this.txtCityState.TabIndex = 10;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(143, 233);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(205, 35);
            this.txtLN.TabIndex = 9;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(143, 158);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(205, 35);
            this.txtFN.TabIndex = 8;
            // 
            // comboAcctType
            // 
            this.comboAcctType.FormattingEnabled = true;
            this.comboAcctType.Location = new System.Drawing.Point(548, 21);
            this.comboAcctType.Name = "comboAcctType";
            this.comboAcctType.Size = new System.Drawing.Size(205, 37);
            this.comboAcctType.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(376, 241);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(94, 24);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNum.Location = new System.Drawing.Point(376, 166);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(164, 24);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "Phone Number:\r\n";
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCityState.Location = new System.Drawing.Point(376, 94);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(117, 24);
            this.lblCityState.TabIndex = 4;
            this.lblCityState.Text = "City/State:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLName.Location = new System.Drawing.Point(11, 239);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(122, 24);
            this.lblLName.TabIndex = 3;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFName.Location = new System.Drawing.Point(11, 164);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(126, 24);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(11, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(126, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Account ID:";
            // 
            // lblAcctType
            // 
            this.lblAcctType.AutoSize = true;
            this.lblAcctType.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcctType.Location = new System.Drawing.Point(375, 30);
            this.lblAcctType.Name = "lblAcctType";
            this.lblAcctType.Size = new System.Drawing.Size(151, 24);
            this.lblAcctType.TabIndex = 0;
            this.lblAcctType.Text = "Accoung Type";
            // 
            // gridChkAcct
            // 
            this.gridChkAcct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridChkAcct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridChkAcct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridChkAcct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridChkAcct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChkAcct.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridChkAcct.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridChkAcct.Location = new System.Drawing.Point(12, 490);
            this.gridChkAcct.Name = "gridChkAcct";
            this.gridChkAcct.Size = new System.Drawing.Size(753, 169);
            this.gridChkAcct.TabIndex = 2;
            // 
            // lblChkInfo
            // 
            this.lblChkInfo.AutoSize = true;
            this.lblChkInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblChkInfo.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChkInfo.Location = new System.Drawing.Point(12, 449);
            this.lblChkInfo.Name = "lblChkInfo";
            this.lblChkInfo.Size = new System.Drawing.Size(475, 38);
            this.lblChkInfo.TabIndex = 14;
            this.lblChkInfo.Text = "Checking Account Information";
            // 
            // lblSavingsInfo
            // 
            this.lblSavingsInfo.AutoSize = true;
            this.lblSavingsInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSavingsInfo.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSavingsInfo.Location = new System.Drawing.Point(764, 449);
            this.lblSavingsInfo.Name = "lblSavingsInfo";
            this.lblSavingsInfo.Size = new System.Drawing.Size(445, 38);
            this.lblSavingsInfo.TabIndex = 15;
            this.lblSavingsInfo.Text = "Savings Account Information";
            // 
            // gridSavings
            // 
            this.gridSavings.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridSavings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridSavings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridSavings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSavings.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridSavings.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridSavings.Location = new System.Drawing.Point(771, 490);
            this.gridSavings.Name = "gridSavings";
            this.gridSavings.Size = new System.Drawing.Size(753, 169);
            this.gridSavings.TabIndex = 16;
            // 
            // lblChkTotal
            // 
            this.lblChkTotal.AutoSize = true;
            this.lblChkTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblChkTotal.Font = new System.Drawing.Font("Rockwell Extra Bold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkTotal.ForeColor = System.Drawing.Color.HotPink;
            this.lblChkTotal.Location = new System.Drawing.Point(904, 195);
            this.lblChkTotal.Name = "lblChkTotal";
            this.lblChkTotal.Size = new System.Drawing.Size(264, 31);
            this.lblChkTotal.TabIndex = 17;
            this.lblChkTotal.Text = "Checking Total:";
            // 
            // txtChkSum
            // 
            this.txtChkSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChkSum.Location = new System.Drawing.Point(1174, 195);
            this.txtChkSum.Name = "txtChkSum";
            this.txtChkSum.Size = new System.Drawing.Size(226, 30);
            this.txtChkSum.TabIndex = 18;
            this.txtChkSum.TextChanged += new System.EventHandler(this.txtChkSum_TextChanged);
            // 
            // btnDispChk
            // 
            this.btnDispChk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDispChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispChk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDispChk.Location = new System.Drawing.Point(910, 129);
            this.btnDispChk.Name = "btnDispChk";
            this.btnDispChk.Size = new System.Drawing.Size(203, 55);
            this.btnDispChk.TabIndex = 19;
            this.btnDispChk.Text = "Display Checking Account";
            this.btnDispChk.UseVisualStyleBackColor = false;
            this.btnDispChk.Click += new System.EventHandler(this.btnDispChk_Click);
            // 
            // btnDispSavings
            // 
            this.btnDispSavings.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDispSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispSavings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDispSavings.Location = new System.Drawing.Point(910, 298);
            this.btnDispSavings.Name = "btnDispSavings";
            this.btnDispSavings.Size = new System.Drawing.Size(203, 55);
            this.btnDispSavings.TabIndex = 22;
            this.btnDispSavings.Text = "Display Saving Account";
            this.btnDispSavings.UseVisualStyleBackColor = false;
            this.btnDispSavings.Click += new System.EventHandler(this.btnDispSavings_Click);
            // 
            // txtSavingsSum
            // 
            this.txtSavingsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsSum.Location = new System.Drawing.Point(1174, 364);
            this.txtSavingsSum.Name = "txtSavingsSum";
            this.txtSavingsSum.Size = new System.Drawing.Size(226, 30);
            this.txtSavingsSum.TabIndex = 21;
            this.txtSavingsSum.TextChanged += new System.EventHandler(this.txtSavingsSum_TextChanged);
            // 
            // lblSavingsTotal
            // 
            this.lblSavingsTotal.AutoSize = true;
            this.lblSavingsTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSavingsTotal.Font = new System.Drawing.Font("Rockwell Extra Bold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsTotal.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblSavingsTotal.Location = new System.Drawing.Point(904, 364);
            this.lblSavingsTotal.Name = "lblSavingsTotal";
            this.lblSavingsTotal.Size = new System.Drawing.Size(237, 31);
            this.lblSavingsTotal.TabIndex = 20;
            this.lblSavingsTotal.Text = "Savings Total:";
            // 
            // comboTransfer
            // 
            this.comboTransfer.FormattingEnabled = true;
            this.comboTransfer.Location = new System.Drawing.Point(143, 23);
            this.comboTransfer.Name = "comboTransfer";
            this.comboTransfer.Size = new System.Drawing.Size(205, 37);
            this.comboTransfer.TabIndex = 16;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrans.Location = new System.Drawing.Point(11, 32);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(136, 24);
            this.lblTrans.TabIndex = 15;
            this.lblTrans.Text = "Transaction:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Week5Day2Assignment1.Properties.Resources.banking;
            this.ClientSize = new System.Drawing.Size(1525, 662);
            this.Controls.Add(this.btnDispSavings);
            this.Controls.Add(this.txtSavingsSum);
            this.Controls.Add(this.lblSavingsTotal);
            this.Controls.Add(this.btnDispChk);
            this.Controls.Add(this.txtChkSum);
            this.Controls.Add(this.lblChkTotal);
            this.Controls.Add(this.gridSavings);
            this.Controls.Add(this.lblSavingsInfo);
            this.Controls.Add(this.lblChkInfo);
            this.Controls.Add(this.gridChkAcct);
            this.Controls.Add(this.grpChecking);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpChecking.ResumeLayout(false);
            this.grpChecking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChkAcct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSavings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpChecking;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.ComboBox comboAcctType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblCityState;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAcctType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView gridChkAcct;
        private System.Windows.Forms.Label lblChkInfo;
        private System.Windows.Forms.Label lblSavingsInfo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView gridSavings;
        private System.Windows.Forms.Label lblChkTotal;
        private System.Windows.Forms.TextBox txtChkSum;
        private System.Windows.Forms.Button btnDispChk;
        private System.Windows.Forms.Button btnDispSavings;
        private System.Windows.Forms.TextBox txtSavingsSum;
        private System.Windows.Forms.Label lblSavingsTotal;
        private System.Windows.Forms.ComboBox comboTransfer;
        private System.Windows.Forms.Label lblTrans;
    }
}

