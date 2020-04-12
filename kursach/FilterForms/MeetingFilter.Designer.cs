namespace kursach
{
    partial class MeetingFilter
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
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkDuration = new System.Windows.Forms.CheckBox();
            this.chkResult = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.cbSignDuration = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // numDate
            // 
            this.numDate.Location = new System.Drawing.Point(259, 128);
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
            // cbResult
            // 
            this.cbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Items.AddRange(new object[] {
            "<NULL>",
            "Успешно",
            "Неуспешно"});
            this.cbResult.Location = new System.Drawing.Point(228, 90);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(151, 21);
            this.cbResult.TabIndex = 22;
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(259, 58);
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 20;
            this.numDuration.Value = new decimal(new int[] {
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
            this.lbltitle.Text = "Фильтр свиданий";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 39);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDuration
            // 
            this.chkDuration.AutoSize = true;
            this.chkDuration.Location = new System.Drawing.Point(20, 58);
            this.chkDuration.Name = "chkDuration";
            this.chkDuration.Size = new System.Drawing.Size(99, 17);
            this.chkDuration.TabIndex = 33;
            this.chkDuration.Text = "Длительность";
            this.chkDuration.UseVisualStyleBackColor = true;
            // 
            // chkResult
            // 
            this.chkResult.AutoSize = true;
            this.chkResult.Location = new System.Drawing.Point(20, 94);
            this.chkResult.Name = "chkResult";
            this.chkResult.Size = new System.Drawing.Size(78, 17);
            this.chkResult.TabIndex = 34;
            this.chkResult.Text = "Результат";
            this.chkResult.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.Location = new System.Drawing.Point(20, 117);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(128, 38);
            this.chkDate.TabIndex = 36;
            this.chkDate.Text = "За последнее время (в днях)";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // cbSignDuration
            // 
            this.cbSignDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignDuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignDuration.FormattingEnabled = true;
            this.cbSignDuration.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignDuration.Location = new System.Drawing.Point(174, 58);
            this.cbSignDuration.Name = "cbSignDuration";
            this.cbSignDuration.Size = new System.Drawing.Size(71, 21);
            this.cbSignDuration.TabIndex = 98;
            // 
            // MeetingFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 221);
            this.Controls.Add(this.cbSignDuration);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.chkResult);
            this.Controls.Add(this.chkDuration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.numDate);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.numDuration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MeetingFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numDate;
        private System.Windows.Forms.ComboBox cbResult;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkDuration;
        private System.Windows.Forms.CheckBox chkResult;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.ComboBox cbSignDuration;
    }
}