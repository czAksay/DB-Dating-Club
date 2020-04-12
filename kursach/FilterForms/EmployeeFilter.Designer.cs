namespace kursach
{
    partial class EmployeeFilter
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
            this.numOrgContracts = new System.Windows.Forms.NumericUpDown();
            this.numOrgDates = new System.Windows.Forms.NumericUpDown();
            this.numSurcharge = new System.Windows.Forms.NumericUpDown();
            this.numTerm = new System.Windows.Forms.NumericUpDown();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.numClub = new System.Windows.Forms.NumericUpDown();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkClub = new System.Windows.Forms.CheckBox();
            this.chkPosition = new System.Windows.Forms.CheckBox();
            this.chkTerm = new System.Windows.Forms.CheckBox();
            this.chkSurcharge = new System.Windows.Forms.CheckBox();
            this.chkOrgDates = new System.Windows.Forms.CheckBox();
            this.chkOrgContracts = new System.Windows.Forms.CheckBox();
            this.cbSignTerm = new System.Windows.Forms.ComboBox();
            this.cbSignSurcharge = new System.Windows.Forms.ComboBox();
            this.cbSignOrgDates = new System.Windows.Forms.ComboBox();
            this.cbSignOrgContracts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOrgContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrgDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSurcharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClub)).BeginInit();
            this.SuspendLayout();
            // 
            // numOrgContracts
            // 
            this.numOrgContracts.Location = new System.Drawing.Point(259, 242);
            this.numOrgContracts.Name = "numOrgContracts";
            this.numOrgContracts.Size = new System.Drawing.Size(120, 20);
            this.numOrgContracts.TabIndex = 30;
            // 
            // numOrgDates
            // 
            this.numOrgDates.Location = new System.Drawing.Point(259, 203);
            this.numOrgDates.Name = "numOrgDates";
            this.numOrgDates.Size = new System.Drawing.Size(120, 20);
            this.numOrgDates.TabIndex = 28;
            // 
            // numSurcharge
            // 
            this.numSurcharge.Location = new System.Drawing.Point(259, 165);
            this.numSurcharge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSurcharge.Name = "numSurcharge";
            this.numSurcharge.Size = new System.Drawing.Size(120, 20);
            this.numSurcharge.TabIndex = 26;
            // 
            // numTerm
            // 
            this.numTerm.Location = new System.Drawing.Point(259, 127);
            this.numTerm.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numTerm.Name = "numTerm";
            this.numTerm.Size = new System.Drawing.Size(120, 20);
            this.numTerm.TabIndex = 24;
            this.numTerm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(228, 90);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(151, 21);
            this.cbPosition.TabIndex = 22;
            // 
            // numClub
            // 
            this.numClub.Location = new System.Drawing.Point(259, 58);
            this.numClub.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClub.Name = "numClub";
            this.numClub.Size = new System.Drawing.Size(120, 20);
            this.numClub.TabIndex = 20;
            this.numClub.Value = new decimal(new int[] {
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
            this.lbltitle.Text = "Фильтр работников";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 39);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkClub
            // 
            this.chkClub.AutoSize = true;
            this.chkClub.Location = new System.Drawing.Point(20, 58);
            this.chkClub.Name = "chkClub";
            this.chkClub.Size = new System.Drawing.Size(92, 17);
            this.chkClub.TabIndex = 33;
            this.chkClub.Text = "Номер клуба";
            this.chkClub.UseVisualStyleBackColor = true;
            // 
            // chkPosition
            // 
            this.chkPosition.AutoSize = true;
            this.chkPosition.Location = new System.Drawing.Point(20, 94);
            this.chkPosition.Name = "chkPosition";
            this.chkPosition.Size = new System.Drawing.Size(84, 17);
            this.chkPosition.TabIndex = 34;
            this.chkPosition.Text = "Должность";
            this.chkPosition.UseVisualStyleBackColor = true;
            // 
            // chkTerm
            // 
            this.chkTerm.AutoSize = true;
            this.chkTerm.Location = new System.Drawing.Point(20, 129);
            this.chkTerm.Name = "chkTerm";
            this.chkTerm.Size = new System.Drawing.Size(91, 17);
            this.chkTerm.TabIndex = 35;
            this.chkTerm.Text = "Срок работы";
            this.chkTerm.UseVisualStyleBackColor = true;
            // 
            // chkSurcharge
            // 
            this.chkSurcharge.AutoSize = true;
            this.chkSurcharge.Location = new System.Drawing.Point(20, 167);
            this.chkSurcharge.Name = "chkSurcharge";
            this.chkSurcharge.Size = new System.Drawing.Size(76, 17);
            this.chkSurcharge.TabIndex = 36;
            this.chkSurcharge.Text = "Надбавка";
            this.chkSurcharge.UseVisualStyleBackColor = true;
            // 
            // chkOrgDates
            // 
            this.chkOrgDates.Location = new System.Drawing.Point(20, 198);
            this.chkOrgDates.Name = "chkOrgDates";
            this.chkOrgDates.Size = new System.Drawing.Size(156, 33);
            this.chkOrgDates.TabIndex = 37;
            this.chkOrgDates.Text = "Кол-во организованных свиданий";
            this.chkOrgDates.UseVisualStyleBackColor = true;
            // 
            // chkOrgContracts
            // 
            this.chkOrgContracts.Location = new System.Drawing.Point(20, 231);
            this.chkOrgContracts.Name = "chkOrgContracts";
            this.chkOrgContracts.Size = new System.Drawing.Size(146, 42);
            this.chkOrgContracts.TabIndex = 38;
            this.chkOrgContracts.Text = "Кол-во оформленных контрактов";
            this.chkOrgContracts.UseVisualStyleBackColor = true;
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
            this.cbSignTerm.Location = new System.Drawing.Point(174, 127);
            this.cbSignTerm.Name = "cbSignTerm";
            this.cbSignTerm.Size = new System.Drawing.Size(71, 21);
            this.cbSignTerm.TabIndex = 94;
            // 
            // cbSignSurcharge
            // 
            this.cbSignSurcharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignSurcharge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignSurcharge.FormattingEnabled = true;
            this.cbSignSurcharge.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignSurcharge.Location = new System.Drawing.Point(174, 165);
            this.cbSignSurcharge.Name = "cbSignSurcharge";
            this.cbSignSurcharge.Size = new System.Drawing.Size(71, 21);
            this.cbSignSurcharge.TabIndex = 95;
            // 
            // cbSignOrgDates
            // 
            this.cbSignOrgDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignOrgDates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignOrgDates.FormattingEnabled = true;
            this.cbSignOrgDates.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignOrgDates.Location = new System.Drawing.Point(174, 203);
            this.cbSignOrgDates.Name = "cbSignOrgDates";
            this.cbSignOrgDates.Size = new System.Drawing.Size(71, 21);
            this.cbSignOrgDates.TabIndex = 96;
            // 
            // cbSignOrgContracts
            // 
            this.cbSignOrgContracts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignOrgContracts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignOrgContracts.FormattingEnabled = true;
            this.cbSignOrgContracts.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignOrgContracts.Location = new System.Drawing.Point(174, 240);
            this.cbSignOrgContracts.Name = "cbSignOrgContracts";
            this.cbSignOrgContracts.Size = new System.Drawing.Size(71, 21);
            this.cbSignOrgContracts.TabIndex = 97;
            // 
            // EmployeeFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 346);
            this.Controls.Add(this.cbSignOrgContracts);
            this.Controls.Add(this.cbSignOrgDates);
            this.Controls.Add(this.cbSignSurcharge);
            this.Controls.Add(this.cbSignTerm);
            this.Controls.Add(this.chkOrgContracts);
            this.Controls.Add(this.chkOrgDates);
            this.Controls.Add(this.chkSurcharge);
            this.Controls.Add(this.chkTerm);
            this.Controls.Add(this.chkPosition);
            this.Controls.Add(this.chkClub);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.numOrgContracts);
            this.Controls.Add(this.numOrgDates);
            this.Controls.Add(this.numSurcharge);
            this.Controls.Add(this.numTerm);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.numClub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numOrgContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrgDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSurcharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numOrgContracts;
        private System.Windows.Forms.NumericUpDown numOrgDates;
        private System.Windows.Forms.NumericUpDown numSurcharge;
        private System.Windows.Forms.NumericUpDown numTerm;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.NumericUpDown numClub;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkClub;
        private System.Windows.Forms.CheckBox chkPosition;
        private System.Windows.Forms.CheckBox chkTerm;
        private System.Windows.Forms.CheckBox chkSurcharge;
        private System.Windows.Forms.CheckBox chkOrgDates;
        private System.Windows.Forms.CheckBox chkOrgContracts;
        private System.Windows.Forms.ComboBox cbSignTerm;
        private System.Windows.Forms.ComboBox cbSignSurcharge;
        private System.Windows.Forms.ComboBox cbSignOrgDates;
        private System.Windows.Forms.ComboBox cbSignOrgContracts;
    }
}