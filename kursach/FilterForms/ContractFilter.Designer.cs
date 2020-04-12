namespace kursach
{
    partial class ContractFilter
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
            this.numDate = new System.Windows.Forms.NumericUpDown();
            this.numSum = new System.Windows.Forms.NumericUpDown();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.numTerm = new System.Windows.Forms.NumericUpDown();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkTerm = new System.Windows.Forms.CheckBox();
            this.chkState = new System.Windows.Forms.CheckBox();
            this.chkSum = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.cbSignSum = new System.Windows.Forms.ComboBox();
            this.cbSignTerm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // numDate
            // 
            this.numDate.Location = new System.Drawing.Point(259, 165);
            this.numDate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDate.Name = "numDate";
            this.numDate.Size = new System.Drawing.Size(120, 20);
            this.numDate.TabIndex = 26;
            this.numDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSum
            // 
            this.numSum.Location = new System.Drawing.Point(259, 127);
            this.numSum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSum.Name = "numSum";
            this.numSum.Size = new System.Drawing.Size(120, 20);
            this.numSum.TabIndex = 24;
            this.numSum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Завершен",
            "Действителен",
            "Отменен"});
            this.cbState.Location = new System.Drawing.Point(228, 90);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(151, 21);
            this.cbState.TabIndex = 22;
            // 
            // numTerm
            // 
            this.numTerm.Location = new System.Drawing.Point(259, 58);
            this.numTerm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTerm.Name = "numTerm";
            this.numTerm.Size = new System.Drawing.Size(120, 20);
            this.numTerm.TabIndex = 20;
            this.numTerm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(-2, 11);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(410, 36);
            this.lbltitle.TabIndex = 31;
            this.lbltitle.Text = "Фильтр контрактов";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 39);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkTerm
            // 
            this.chkTerm.AutoSize = true;
            this.chkTerm.Location = new System.Drawing.Point(20, 58);
            this.chkTerm.Name = "chkTerm";
            this.chkTerm.Size = new System.Drawing.Size(106, 17);
            this.chkTerm.TabIndex = 33;
            this.chkTerm.Text = "Срок контракта";
            this.chkTerm.UseVisualStyleBackColor = true;
            // 
            // chkState
            // 
            this.chkState.AutoSize = true;
            this.chkState.Location = new System.Drawing.Point(20, 94);
            this.chkState.Name = "chkState";
            this.chkState.Size = new System.Drawing.Size(80, 17);
            this.chkState.TabIndex = 34;
            this.chkState.Text = "Состояние";
            this.chkState.UseVisualStyleBackColor = true;
            // 
            // chkSum
            // 
            this.chkSum.AutoSize = true;
            this.chkSum.Location = new System.Drawing.Point(20, 130);
            this.chkSum.Name = "chkSum";
            this.chkSum.Size = new System.Drawing.Size(52, 17);
            this.chkSum.TabIndex = 35;
            this.chkSum.Text = "Цена";
            this.chkSum.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.Location = new System.Drawing.Point(20, 154);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(128, 38);
            this.chkDate.TabIndex = 36;
            this.chkDate.Text = "За последнее время (в днях)";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // cbSignSum
            // 
            this.cbSignSum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignSum.FormattingEnabled = true;
            this.cbSignSum.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignSum.Location = new System.Drawing.Point(174, 127);
            this.cbSignSum.Name = "cbSignSum";
            this.cbSignSum.Size = new System.Drawing.Size(71, 21);
            this.cbSignSum.TabIndex = 94;
            // 
            // cbSignTerm
            // 
            this.cbSignTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignTerm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignTerm.FormattingEnabled = true;
            this.cbSignTerm.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignTerm.Location = new System.Drawing.Point(174, 56);
            this.cbSignTerm.Name = "cbSignTerm";
            this.cbSignTerm.Size = new System.Drawing.Size(71, 21);
            this.cbSignTerm.TabIndex = 98;
            // 
            // ContractFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 271);
            this.Controls.Add(this.cbSignTerm);
            this.Controls.Add(this.cbSignSum);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.chkSum);
            this.Controls.Add(this.chkState);
            this.Controls.Add(this.chkTerm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.numDate);
            this.Controls.Add(this.numSum);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.numTerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ContractFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numDate;
        private System.Windows.Forms.NumericUpDown numSum;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.NumericUpDown numTerm;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkTerm;
        private System.Windows.Forms.CheckBox chkState;
        private System.Windows.Forms.CheckBox chkSum;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.ComboBox cbSignSum;
        private System.Windows.Forms.ComboBox cbSignTerm;
    }
}