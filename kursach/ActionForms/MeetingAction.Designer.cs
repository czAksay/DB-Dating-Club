namespace kursach
{
    partial class MeetingAction
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
            this.numPlaceID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numClientID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numEmployeeID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.pnlId = new System.Windows.Forms.Panel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlaceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(-1, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(350, 28);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "TEXT";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPlaceID
            // 
            this.numPlaceID.Location = new System.Drawing.Point(207, 115);
            this.numPlaceID.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numPlaceID.Name = "numPlaceID";
            this.numPlaceID.Size = new System.Drawing.Size(120, 20);
            this.numPlaceID.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID места свидания";
            // 
            // numClientID
            // 
            this.numClientID.Location = new System.Drawing.Point(207, 78);
            this.numClientID.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numClientID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClientID.Name = "numClientID";
            this.numClientID.Size = new System.Drawing.Size(120, 20);
            this.numClientID.TabIndex = 14;
            this.numClientID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID клиента";
            // 
            // numEmployeeID
            // 
            this.numEmployeeID.Location = new System.Drawing.Point(207, 296);
            this.numEmployeeID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEmployeeID.Name = "numEmployeeID";
            this.numEmployeeID.Size = new System.Drawing.Size(120, 20);
            this.numEmployeeID.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 98;
            this.label3.Text = "ID работника-организатора";
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
            this.cbResult.Location = new System.Drawing.Point(177, 256);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(151, 21);
            this.cbResult.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Результат";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(207, 221);
            this.numDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 95;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 94;
            this.label2.Text = "Длительность (мин.)";
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(273, 188);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(53, 20);
            this.numMinutes.TabIndex = 93;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(214, 188);
            this.numHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(53, 20);
            this.numHours.TabIndex = 92;
            this.numHours.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Время проведения";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(255, 153);
            this.numYear.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1901,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(72, 20);
            this.numYear.TabIndex = 90;
            this.numYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(196, 153);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(53, 20);
            this.numMonth.TabIndex = 89;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(137, 153);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(53, 20);
            this.numDay.TabIndex = 88;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Дата проведения";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 331);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(324, 39);
            this.btnAction.TabIndex = 100;
            this.btnAction.Text = "Text";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.tbId);
            this.pnlId.Controls.Add(this.label28);
            this.pnlId.Enabled = false;
            this.pnlId.Location = new System.Drawing.Point(2, 36);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(344, 31);
            this.pnlId.TabIndex = 101;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(94, 6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(185, 20);
            this.tbId.TabIndex = 42;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(63, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "ID";
            // 
            // MeetingAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 387);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.numEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPlaceID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numClientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MeetingAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numPlaceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.NumericUpDown numPlaceID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label28;
    }
}