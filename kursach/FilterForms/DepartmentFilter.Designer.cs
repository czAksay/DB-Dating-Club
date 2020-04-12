namespace kursach
{
    partial class DepartmentFilter
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkRent = new System.Windows.Forms.CheckBox();
            this.cbSign = new System.Windows.Forms.ComboBox();
            this.numSum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(-1, 15);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(425, 30);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Фильтр отделений";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // chkRent
            // 
            this.chkRent.AutoSize = true;
            this.chkRent.Location = new System.Drawing.Point(12, 48);
            this.chkRent.Name = "chkRent";
            this.chkRent.Size = new System.Drawing.Size(110, 17);
            this.chkRent.TabIndex = 43;
            this.chkRent.Text = "Плата за аренду";
            this.chkRent.UseVisualStyleBackColor = true;
            // 
            // cbSign
            // 
            this.cbSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSign.FormattingEnabled = true;
            this.cbSign.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSign.Location = new System.Drawing.Point(205, 46);
            this.cbSign.Name = "cbSign";
            this.cbSign.Size = new System.Drawing.Size(71, 21);
            this.cbSign.TabIndex = 44;
            // 
            // numSum
            // 
            this.numSum.Location = new System.Drawing.Point(292, 46);
            this.numSum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSum.Name = "numSum";
            this.numSum.Size = new System.Drawing.Size(120, 20);
            this.numSum.TabIndex = 45;
            // 
            // DepartmentFilter
            // 
            this.ClientSize = new System.Drawing.Size(424, 133);
            this.Controls.Add(this.numSum);
            this.Controls.Add(this.cbSign);
            this.Controls.Add(this.chkRent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepartmentFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkRent;
        private System.Windows.Forms.ComboBox cbSign;
        private System.Windows.Forms.NumericUpDown numSum;
    }
}