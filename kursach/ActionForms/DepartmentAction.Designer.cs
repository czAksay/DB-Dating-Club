namespace kursach
{
    partial class DepartmentAction
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
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPayment = new System.Windows.Forms.NumericUpDown();
            this.numHouse2 = new System.Windows.Forms.NumericUpDown();
            this.numHouse = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.pnlComponents = new System.Windows.Forms.Panel();
            this.pnlId = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHouse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHouse)).BeginInit();
            this.pnlComponents.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(-1, 15);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(493, 30);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "TEXT";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 422);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(465, 39);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "Text";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(135, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(327, 20);
            this.tbName.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(2, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Квартира";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(2, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Номер дома";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(2, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Улица";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(135, 126);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(327, 20);
            this.tbStreet.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(2, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Город";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(135, 90);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(327, 20);
            this.tbCity.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Страна";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(136, 54);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(327, 20);
            this.tbCountry.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Арендная плата";
            // 
            // numPayment
            // 
            this.numPayment.Location = new System.Drawing.Point(325, 230);
            this.numPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPayment.Name = "numPayment";
            this.numPayment.Size = new System.Drawing.Size(137, 20);
            this.numPayment.TabIndex = 38;
            // 
            // numHouse2
            // 
            this.numHouse2.Location = new System.Drawing.Point(325, 194);
            this.numHouse2.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numHouse2.Name = "numHouse2";
            this.numHouse2.Size = new System.Drawing.Size(137, 20);
            this.numHouse2.TabIndex = 39;
            // 
            // numHouse
            // 
            this.numHouse.Location = new System.Drawing.Point(326, 161);
            this.numHouse.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numHouse.Name = "numHouse";
            this.numHouse.Size = new System.Drawing.Size(137, 20);
            this.numHouse.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(136, 6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(327, 20);
            this.tbId.TabIndex = 42;
            // 
            // pnlComponents
            // 
            this.pnlComponents.Controls.Add(this.label1);
            this.pnlComponents.Controls.Add(this.tbName);
            this.pnlComponents.Controls.Add(this.numHouse);
            this.pnlComponents.Controls.Add(this.tbCountry);
            this.pnlComponents.Controls.Add(this.numHouse2);
            this.pnlComponents.Controls.Add(this.label8);
            this.pnlComponents.Controls.Add(this.numPayment);
            this.pnlComponents.Controls.Add(this.tbCity);
            this.pnlComponents.Controls.Add(this.label3);
            this.pnlComponents.Controls.Add(this.label9);
            this.pnlComponents.Controls.Add(this.label12);
            this.pnlComponents.Controls.Add(this.tbStreet);
            this.pnlComponents.Controls.Add(this.label11);
            this.pnlComponents.Controls.Add(this.label10);
            this.pnlComponents.Location = new System.Drawing.Point(12, 81);
            this.pnlComponents.Name = "pnlComponents";
            this.pnlComponents.Size = new System.Drawing.Size(465, 276);
            this.pnlComponents.TabIndex = 43;
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.tbId);
            this.pnlId.Controls.Add(this.label2);
            this.pnlId.Enabled = false;
            this.pnlId.Location = new System.Drawing.Point(12, 44);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(465, 31);
            this.pnlId.TabIndex = 44;
            // 
            // DepartmentAction
            // 
            this.ClientSize = new System.Drawing.Size(489, 480);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pnlComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepartmentAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHouse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHouse)).EndInit();
            this.pnlComponents.ResumeLayout(false);
            this.pnlComponents.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPayment;
        private System.Windows.Forms.NumericUpDown numHouse2;
        private System.Windows.Forms.NumericUpDown numHouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Panel pnlComponents;
        private System.Windows.Forms.Panel pnlId;
    }
}